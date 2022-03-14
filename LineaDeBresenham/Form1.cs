namespace LineasDeBresenham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            
            panel.Invalidate();

            int x1 = Int32.Parse(tbX1.Text);
            int x2 = Int32.Parse(tbX2.Text);
            int y1 = Int32.Parse(tbY1.Text);
            int y2 = Int32.Parse(tbY2.Text);
            
            MathClass.LineaBresenham.bresenham(x1, y1, x2, y2, panel);
            //MathClass.LineaBresenham.LinearBresenham(x1, y1, x2, y2, panel);
             
             
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

              MathClass.LineaBresenham.plano(panel);

        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            
            int x1 = Int32.Parse(tbX1.Text);
            int x2 = Int32.Parse(tbX2.Text);
            int y1 = Int32.Parse(tbY1.Text);
            int y2 = Int32.Parse(tbY2.Text);

            MathClass.LineaBresenham.LinearBresenham(x1, y1, x2, y2, panel);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MathClass.LineaBresenham.plano(panel);
        }

    }
}