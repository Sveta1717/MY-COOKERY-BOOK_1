using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using ListView = System.Windows.Forms.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace MY_COOKERY_BOOK
{
    public partial class Form1 : Form
    {              
        private ListView table;
        public ImageList image;

        public Form1()
        {
            BackColor = Color.Tan;
            Height = 250;
            Width = 250;
            InitializeComponent();
            Text = "МОЯ КУЛІНАРНА КНИГА";
            Font = new Font("", 15);
            button1.Text = "Добавити рецепт";
            button2.Text = "Редагувати рецепт";
            button3.Text = "Видалити рецепт";              
        }
        
        private void першіБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new ListView();
            ListViewItem item1 = new ListViewItem("Бограч", 0);
            item1.Checked = true;
            item1.SubItems.Add("1");
            ListViewItem item2 = new ListViewItem("Борщ", 0);
            item2.Checked = true;
            item2.SubItems.Add("2");
            ListViewItem item3 = new ListViewItem("Гуляш", 0);
            item3.Checked = true;
            item3.SubItems.Add("3");
            table.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            table.SetBounds(5, 25, 400, 800);
            this.Controls.Add(table);
            table.View = View.Tile;
            table.BackColor = Color.Bisque;
            table.Font = new Font(table.Font, FontStyle.Bold);
            table.FullRowSelect = true;
            table.LabelEdit = true;
            image = new ImageList();
            //image.Images.Add(Bitmap.FromFile("1.bmp"));
            //image.Images.Add(Bitmap.FromFile("2.bmp"));
            //image.Images.Add(Bitmap.FromFile("3.bmp"));
            table.LargeImageList = image;
            table.Sorting = SortOrder.Ascending;
            //table.Enabled = !table.Enabled;
            table.Enabled = true;
        }

        private void другіБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new ListView();
            table.SetBounds(5, 25, 400, 800);
            this.Controls.Add(table);
            table.Items.Add(new ListViewItem("Качка з яблуками"));            
            table.Items.Add(new ListViewItem("Лазанья"));
            table.Items.Add(new ListViewItem("Беф-строганов"));
            table.Items.Add(new ListViewItem("Котлета по київські"));
            table.Items.Add(new ListViewItem("Риба фіш"));
            table.View = View.Tile;
            table.BackColor = Color.Bisque;
            table.Font = new Font(table.Font, FontStyle.Bold);
            table.FullRowSelect = true;                  
            table.Sorting = SortOrder.Ascending;
        }

        private object ComboBox(string v)
        {
            throw new NotImplementedException();
        }

        private void салатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table = new ListView();
            table.SetBounds(5, 25, 400, 800);           
            this.Controls.Add(table);       
            table.Items.Add(new ListViewItem("Мімоза"));
            table.Items.Add(new ListViewItem("Олів'є"));
            table.Items.Add(new ListViewItem("Капрезе"));
            table.Items.Add(new ListViewItem("Санта-Барбара"));
            table.Items.Add(new ListViewItem("Вісняний"));
            table.Items.Add(new ListViewItem("Гранат"));              
            table.View = View.Tile;
            table.BackColor = Color.Bisque;
            table.Font = new Font(table.Font, FontStyle.Bold);  
            table.FullRowSelect = true;              
        }       
      
        private void button3_Click(object sender, EventArgs e)
        {
            if (table.Items.Count != 0)
            {
                if (table.SelectedItems != null)
                {
                    for (int i = 0; i < table.SelectedItems.Count; i++)
                    {
                        table.Items.Remove(table.SelectedItems[i]);

                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {            
            table.Items.Add("  ");           
        }              
    }
}
