using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e) {
            try {
                using (ExpertSystemContext context = new ExpertSystemContext()) {
                    if (label.Text == context.knowladgeBase.Where(a => a.Id == 0).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 1).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 1).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 17).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 18).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 19).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 20).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 21).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 3).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 5).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 5).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 7).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 6).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 9).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 9).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 11).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 4).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 13).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 14).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 15).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 2).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 3).Select(a => a.Knowladge).SingleOrDefault();
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoButton_Click(object sender, EventArgs e) {
            try {
                using (ExpertSystemContext context = new ExpertSystemContext()) {
                    if (label.Text == context.knowladgeBase.Where(a => a.Id == 0).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 2).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 1).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 18).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 18).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 20).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 18).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 20).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 20).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 22).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 2).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 4).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 5).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 8).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 14).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 16).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 3).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 6).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 6).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 10).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 9).Select(a => a.Knowladge).SingleOrDefault()) {
                        ResultLabel.Text = context.knowladgeBase.Where(a => a.Id == 12).Select(a => a.Knowladge).SingleOrDefault();
                    } else if (label.Text == context.knowladgeBase.Where(a => a.Id == 4).Select(a => a.Knowladge).SingleOrDefault()) {
                        label.Text = context.knowladgeBase.Where(a => a.Id == 14).Select(a => a.Knowladge).SingleOrDefault();
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e) {
            try {
                using (ExpertSystemContext context = new ExpertSystemContext()) {
                    label.Text = (from kn in context.knowladgeBase
                                  where kn.Id == 0
                                  select kn.Knowladge).SingleOrDefault();
                    ResultLabel.Text = "";
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HelpPictureBox_Click(object sender, EventArgs e) {
            try {
                using (ExpertSystemContext context = new ExpertSystemContext()) {
                    if (ResultLabel.Text != "") {
                        MessageBox.Show(context.knowladgeBase.Where(kn => kn.Knowladge == ResultLabel.Text).Select(kn => kn.KnowDescription).SingleOrDefault(), 
                            "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else {
                        MessageBox.Show("Для того, чтобы воспользоваться функционалом экспертной системой, пользуйтесь копками Да и Нет.", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception exc) {
                MessageBox.Show(exc.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}