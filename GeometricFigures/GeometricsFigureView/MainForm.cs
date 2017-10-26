using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeometricFigures;
using Newtonsoft.Json;
using System.IO;

namespace GeometricsFigureView
{
    public partial class MainForm : Form
    {
        private List<IFigure> _figures;

        private Dictionary<string, double> figureDictionary;
        public MainForm()
        {
            InitializeComponent();
            _figures = new List<IFigure>();
            iFiguresBindingSource.DataSource = _figures;
            figureDictionary = new Dictionary<string, double>();
        }

 

        private void AddFigureButton_Click(object sender, EventArgs e)
        {
            var form = new AddFigureForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                iFiguresBindingSource.Add(form.Figure);
                figureDictionary.Add(form.Figure.Type, form.Figure.Perimeter);
            }
        }

        private void ModifyFigureButton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current == null)
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите изменить.", @"Ошибка!");
            }
            else
            {
                var index = FigureDataGridView.SelectedCells[0].RowIndex;
                var form = new AddFigureForm
                {
                    Figure = _figures[index]
                };
                if (form.ShowDialog() == DialogResult.OK)
                {
                    iFiguresBindingSource.RemoveAt(index);
                    iFiguresBindingSource.Insert(index, form.Figure);
                }
            }
        }

        private void RemoveFigureButton_Click(object sender, EventArgs e)
        {
            if (iFiguresBindingSource.Current != null)
            {
                foreach (DataGridViewRow r in FigureDataGridView.SelectedRows)
                {
                    iFiguresBindingSource.RemoveAt(r.Index);
                    figureDictionary.Clear();
                }
            }
            else
            {
                MessageBox.Show(@"Вы не выбрали строку, которую хотите удалить.", @"Ошибка!");
            }
        }

        private void RandomFigureButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            iFiguresBindingSource.Add(new Rectangle(rnd.Next(1, 30), rnd.Next(1, 30)));
            iFiguresBindingSource.Add(new Triangle(10, 20, 29));
            iFiguresBindingSource.Add(new Circle(rnd.Next(1, 10)));
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
            {
                _figures = Serialization.Deserializing(ofd.FileName);
                iFiguresBindingSource.DataSource = _figures;
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (_figures.Count != 0)
             {
                 var ofd = new SaveFileDialog
                 {
                     Filter = @"dat files (*.dat)|*.dat",
                     RestoreDirectory = true
                 };
                 if (!(ofd.FileName == null || ofd.ShowDialog() == DialogResult.Cancel))
                 {
                     Serialization.Serializing(ofd.FileName, _figures);
                 }
             }
             else
             {
                 MessageBox.Show(@"Ошибка. Файл не може быть пустым");
             }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != string.Empty)
            {
                for (var i = 0; i < FigureDataGridView.RowCount; i++)
                {
                    FigureDataGridView.Rows[i].Selected = false;
                    for (var j = 0; j < FigureDataGridView.ColumnCount; j++)
                    {
                        if (FigureDataGridView.Rows[i].Cells[j].Value == null)
                        {
                            continue;
                        }
                        if (!FigureDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(SearchTextBox.Text.ToLower()))
                        {
                            continue;
                        }
                        FigureDataGridView.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Введите значение поиска", @"Ошибка!");
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_figures.Count == 0)
            {
                MessageBox.Show("Список фигур пуст");
            }
            var saveFileDialogForm = new SaveFileDialog();
            saveFileDialogForm.Filter = "Списки фигур (.ifgr)|*.ifgr";
            if (saveFileDialogForm.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialogForm.FileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, _figures);
                }
                MessageBox.Show("Список сохранен");
            };
        }

        private JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };

        private void button2_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
                openFile.Filter = "Списки фигур (.ifgr)|*.ifgr";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(openFile.FileName))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        _figures = (List<IFigure>)serializer.Deserialize(reader, typeof(List<IFigure>));
                        FigureDataGridView.Rows.Clear();
                        foreach (var data in _figures)
                        {
                            FigureDataGridView.Rows.Add(data.GetType().Name, data.Area, data.Perimeter);
                        };
                    }
                }
            }

        
        
    }
    }

