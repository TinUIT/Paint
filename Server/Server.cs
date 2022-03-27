using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 600;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog dlg = new ColorDialog();
        Color new_color;

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        void Connect()
        {
            clientList = new List<Socket>();
            // Địa chỉ Server
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        clientList.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        void Close()
        {
            server.Close();
        }

        void Send(Socket client, string s)
        {
            if (s != String.Empty)
            {
                client.Send(Serialize(s));
            }
        }

        void Receive(Object obj)
        {
            Socket client = (Socket)obj;
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 500];
                    client.Receive(data);

                    string Message = (string)Deserialize(data);
                    foreach (Socket item in clientList)
                    {
                        Send(item, Message);
                    }

                    AddMessage(Message);
                }
                catch
                {
                    clientList.Remove(client);
                    client.Close();
                }
            }
        }

        void AddMessage(string m)
        {
            listViewChat.Items.Add(new ListViewItem() { Text = m });
        }

        byte[] Serialize(Object obj)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(ms, obj);

            return ms.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();

            return bf.Deserialize(ms);

        }

        private void pic_MouseDown_1(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {

                if (paint)
                {
                    if (index == 1)
                    {
                        px = e.Location;
                        g.DrawLine(p, px, py);
                        py = px;
                    }
                    if (index == 2)
                    {
                        px = e.Location;
                        g.DrawLine(erase, px, py);
                        py = px;
                    }
                }
                pic.Refresh();

                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
                Graphics g = e.Graphics;
                if (paint)
                {
                    if (index == 3)
                    {
                        g.DrawEllipse(p, cX, cY, sX, sY);
                    }
                    if (index == 4)
                    {
                        g.DrawRectangle(p, cX, cY, sX, sY);
                    }
                    if (index == 5)
                    {
                        g.DrawLine(p, cX, cY, x, y);
                    }
                }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            
                g.Clear(Color.White);
                pic.Image = bm;
                index = 0;
            
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
        
                dlg.ShowDialog();
                new_color = dlg.Color;
                pic_color.BackColor = dlg.Color;
                p.Color = dlg.Color;
            
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            
                paint = false;

                sX = x - cX;
                sY = y - cY;

                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            {
                Point point = set_point(color_picker, e.Location);
                pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
                new_color = pic_color.BackColor;
                p.Color = pic_color.BackColor;
            }
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            {
                index = 3;
            }
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            {
                index = 4;
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            {
                if (index == 7)
                {
                    Point point = set_point(pic, e.Location);
                    Fill(bm, point.X, point.Y, new_color);
                }
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            {
                index = 1;
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btn_chat_Click(object sender, EventArgs e)
        {
            foreach (Socket item in clientList)
            {
                Send(item, "Server: " + textBoxChat.Text);
            }
            AddMessage("Server: " + textBoxChat.Text);
            textBoxChat.Clear();
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            {
                index = 2;
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            {
                index = 7;
            }
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            {
                index = 5;
            }
        }


        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_Color, Color new_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_Color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_Color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_Color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_Color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_Color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_Color, new_clr);
                }
            }
        }
    }
}
