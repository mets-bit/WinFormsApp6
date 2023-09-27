namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private List<GroupBox> groupBoxes;

        public Form1()
        {
            InitializeComponent();
            InitializeGroupBoxes();
        }

        private void InitializeGroupBoxes()
        {
            // I-add ang iyong mga GroupBox sa listahan
            groupBoxes = new List<GroupBox> { groupBox1, groupBox2, groupBox3, groupBox4 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Prev_Btn_Click(object sender, EventArgs e)
        {
            {
                int maxColumntbl1 = tableLayoutPanel1.ColumnCount - 1; // Maximum column index for tableLayoutPanel1
                int maxColumntbl3 = tableLayoutPanel3.ColumnCount - 1; // Maximum column index for tableLayoutPanel3

                foreach (var groupBox in groupBoxes)
                {
                    int currentColumn1 = tableLayoutPanel1.GetColumn(groupBox);
                    int currentColumn3 = tableLayoutPanel3.GetColumn(groupBox);

                    if (currentColumn1 == 0)
                    {


                        // If the GroupBox is in the first column of tableLayoutPanel1,
                        // move it to the last column of tableLayoutPanel3.
                        tableLayoutPanel1.Controls.Remove(groupBox); // Remove from tableLayoutPanel1
                        tableLayoutPanel3.Controls.Add(groupBox, maxColumntbl3, 0); // Add to tableLayoutPanel3 at last column
                    }
                    else if (currentColumn3 == 0)
                    {
                        // If the GroupBox is in the first column of tableLayoutPanel3,
                        // move it to the last column of tableLayoutPanel1.
                        tableLayoutPanel3.Controls.Remove(groupBox); // Remove from tableLayoutPanel3
                        tableLayoutPanel1.Controls.Add(groupBox, maxColumntbl1, 0); // Add to tableLayoutPanel1 at last column
                    }
                    else
                    {
                        // Move the GroupBox to the previous column within its current tableLayoutPanel
                        if (currentColumn1 > 0)
                        {
                            int newColumn1 = currentColumn1 - 1;
                            tableLayoutPanel1.SetColumn(groupBox, newColumn1); // Move to the previous column of tableLayoutPanel1
                        }
                        else if (currentColumn3 > 0)
                        {
                            int newColumn3 = currentColumn3 - 1;
                            tableLayoutPanel3.SetColumn(groupBox, newColumn3); // Move to the previous column of tableLayoutPanel3
                        }
                    }
                }
            }
        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {
            int maxColumn1 = tableLayoutPanel1.ColumnCount - 1; // Maximum column index for tableLayoutPanel1
            int maxColumn3 = tableLayoutPanel3.ColumnCount - 1; // Maximum column index for tableLayoutPanel3

            foreach (var groupBox in groupBoxes)
            {
                int currentColumn1 = tableLayoutPanel1.GetColumn(groupBox);
                int currentColumn3 = tableLayoutPanel3.GetColumn(groupBox);

                if (currentColumn3 == maxColumn3)
                {
                    // If the GroupBox is in the last column of tableLayoutPanel3,
                    // move it to the first column of tableLayoutPanel1.
                    tableLayoutPanel3.Controls.Remove(groupBox); // Remove from tableLayoutPanel3
                    tableLayoutPanel1.Controls.Add(groupBox, 0, 0); // Add to tableLayoutPanel1 at first column
                }
                else if (currentColumn1 == maxColumn1)
                {
                    // If the GroupBox is in the last column of tableLayoutPanel1,
                    // move it to the first column of tableLayoutPanel3.
                    tableLayoutPanel1.Controls.Remove(groupBox); // Remove from tableLayoutPanel1
                    tableLayoutPanel3.Controls.Add(groupBox, 0, 0); // Add to tableLayoutPanel3 at first column
                }
                else
                {
                    int newColumn1 = currentColumn1 + 1;
                    tableLayoutPanel1.SetColumn(groupBox, newColumn1); // Move to the next column of tableLayoutPanel1
                }
            }
        }
    }
    }