using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Cinema.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Presentation
{
    public partial class ChangeProjectionForm : Form
    {
        private Projection currentProjection;
        public ChangeProjectionForm()
        {
            InitializeComponent();
        }

        private void ChangeProjectionForm_Load(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                currentProjection = entities.Projections
                    .OrderBy(Projection => Projection.Id)
                    .First();
            }

            projectionTextBox.Text = currentProjection.Name;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<Projection> prevProjections = entities.Projections
                    .Where(projection => projection.Id < currentProjection.Id)
                    .OrderBy(projection => projection.Id)
                    .ToList();

                if (prevProjections.Count > 0)
                {
                    currentProjection = prevProjections.Last();
                    projectionTextBox.Text = currentProjection.Name;
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<Projection> nextProjections = entities.Projections
                    .Where(projection => projection.Id > currentProjection.Id)
                    .OrderBy(projection => projection.Id)
                    .ToList();

                if (nextProjections.Count > 0)
                {
                    currentProjection = nextProjections.First();
                    projectionTextBox.Text = currentProjection.Name;
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Projection projection = new Projection()
                {
                    Name = projectionTextBox.Text
                };

                entities.Projections.Add(projection);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Projection oldProjection = entities.Projections.Find(currentProjection.Id);

                Projection newProjection = new Projection()
                {
                    Id = currentProjection.Id,
                    Name = projectionTextBox.Text
                };

                entities.Entry(oldProjection).CurrentValues.SetValues(newProjection);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }
    }
}
