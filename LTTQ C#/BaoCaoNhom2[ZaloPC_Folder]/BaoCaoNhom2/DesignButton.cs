using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BoTronButton
{
    //Chuyển đổi lớp thành public class và kế thừa từ nút button của thư viện windows 
    class DesignButton : Button
    {
        //tạo biến kích thước dường viền
        private int borderSize = 0;
        //Bán kính đường viền
        private int borderRadius = 40;
        //Màu đường viền
        private Color borderColer = Color.PaleVioletRed;


        //Properties
        //Nhóm các thuộc tính này trong 1 danh mục và đặt tên
        [Category("Design")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                //Mỗi khi thuộc tính được thay đổi giá trị thì sẽ vẽ lại nút để cập nhật giao diện
                this.Invalidate();
            }
        }
        //Nhóm các thuộc tính này trong 1 danh mục và đặt tên
        [Category("Design")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                //Mỗi khi thuộc tính được thay đổi giá trị thì sẽ vẽ lại nút để cập nhật giao diện
                this.Invalidate();
            }
        }
        //Nhóm các thuộc tính này trong 1 danh mục và đặt tên
        [Category("Design")]
        public Color BorderColer
        {
            get => borderColer;
            set
            {
                borderColer = value;
                //Mỗi khi thuộc tính được thay đổi giá trị thì sẽ vẽ lại nút để cập nhật giao diện
                this.Invalidate();
            }
        }

        //Thêm 2 thuộc tính để thay đổi màu nền và màu văn bản
        //Nhóm các thuộc tính này trong 1 danh mục và đặt tên
        [Category("Design")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        //Nhóm các thuộc tính này trong 1 danh mục và đặt tên
        [Category("Design")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Trong hàm tạo (Constructor), khởi tạo 1 số thuộc tính mặc định cho nút
        public DesignButton()
        {
            //Nút sẽ có kiểu:
            //Phẳng 
            this.FlatStyle = FlatStyle.Flat;
            //không viền
            this.FlatAppearance.BorderSize = 0;
            //Kích thước cụ thể
            this.Size = new Size(150, 40);
            //Màu nền
            this.BackColor = Color.MediumSlateBlue;
            //Màu chữ
            this.ForeColor = Color.White;
        }

        //Khai báo 1 phương thức để lấy đường dẫn đồ họa cho hình dạng nút
        //Với đường viền nút có thể tùy chỉnh

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            //Tạo 1 đối tượng đường dẫn đồ họa: path
            GraphicsPath path = new GraphicsPath();
            //Bắt đầu vẽ:
            path.StartFigure();
            //Bắt đầu bo tròn góc trên bên trái với cung bắt đầu từ góc 180 độ và phạm vi 90 độ
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            //Bo tròn góc trên bên phải với cung bắt đầu từ góc 270 độ và phạm vi 90
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            //Bo tròn góc trên bên trái với cung bắt đầu từ góc 0 độ và phạm vi 90
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            //Bo tròn góc trên bên trái với cung bắt đầu từ góc 90 độ và phạm vi 90
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            //Hoàn thiện hình và trả lại dduongf dẫn đồ hoạn
            path.CloseFigure();
            return path;
        }

        //Ghi đè sự kiện OnPaint để mở rộng chức năng
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //Đặt chế độ làm mịn thành chống bí danh
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Tạo 1 đối tượng hình chữ nhật có giá trị nổi cho bề mặt bên ngoài của nút
            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            //Tạo hình chữ nhật thứ 2 nhỏ hơn hình 1
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            //Nếu borderRadius > 2 thì nó là 1 nút được làm tròn
            //ngược lại nó là nút hình vuông bình thường
            if (borderRadius > 2)
            {
                //Tạo 1 đường dẫn đồ họa cho bề mặt nút bằng câu lệnh using
                //Câu lệnh using cho phép loại bỏ các đối tượng tiếp tục 1 cách chính xác
                //getfigurepath(hình chữ nhật, giá trị bán kính)
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1f))
                //Tạo đối tượng pen cho nút có cùng màu nền với độ dày là 2
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                //Tạo đối tượng pen cho đường viền nút
                using (Pen penBorder = new Pen(borderColer, borderSize))
                {
                    //Đặt bút viền
                    penBorder.Alignment = PenAlignment.Inset;

                    //Bề mặt nút

                    //Đặt 1 vùng mới cho nút được xác định trên đường dẫn đồ họa bề mặt
                    this.Region = new Region(pathSurface);
                    //Vẽ đường viền bề mặt
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Vẽ đường viền của nút
                    //Đường viền chỉ được vẽ khi kích thước đường viền >= 1
                    if (borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penSurface, pathBorder);
                    }

                }
            }
            else
            {
                //Đặt 1 vùng mới cho nút được xác định trên đường dẫn đồ họa bề mặt
                //Dùng các giá trị của rectSurface dòng 68
                this.Region = new Region(rectSurface);
                //Đường viền nút chỉ được vẽ khi kích thước đường viền >= 1
                if (borderSize >= 1)
                {
                    //Tạo 1 đối tượng pen và vẽ 1 hình chũ nhật
                    using (Pen penBorder = new Pen(borderColer, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        //ghi đè onhand
        //Phương thức này đảm bảo màu đường viền thay đổi theo màu nền nếu màu nền được thay đổi
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        //Cập nhật giao diện
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            //Nếu cần thay đổi màu nền của vùng gốc thì dùng dk bên dưới
            if (this.DesignMode)
            {
                //Cập nhật giao diện nút trong thời gian chạy
                this.Invalidate();
            }
        }
    }
}
