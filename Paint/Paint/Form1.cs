namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics GraphicsPanel;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            GraphicsPanel = PanelPaint.CreateGraphics();
            pen = new Pen(Color.Black,5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;

        }

        private void PanelPaint_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x= e.X;
            y= e.Y;
        }

        private void PanelPaint_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void PanelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                GraphicsPanel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
    }
}