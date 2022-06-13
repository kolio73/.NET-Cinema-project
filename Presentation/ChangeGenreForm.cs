using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Cinema.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Presentation
{
    public partial class ChangeGenreForm : Form
    {
        private Genre currentGenre;
        public ChangeGenreForm()
        {
            InitializeComponent();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<Genre> prevGenres = entities.Genres
                    .Where(genre => genre.Id < currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (prevGenres.Count > 0)
                {
                    currentGenre = prevGenres.Last();
                    genreTextBox.Text = currentGenre.Name;
                }
                else
                {
                    prevButton.Enabled = false;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<Genre> nextGenres = entities.Genres
                    .Where(genre => genre.Id > currentGenre.Id)
                    .OrderBy(genre => genre.Id)
                    .ToList();

                if (nextGenres.Count > 0)
                {   
                    currentGenre = nextGenres.First();
                    genreTextBox.Text = currentGenre.Name;
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Genre genre = new Genre()
                {
                    Name = genreTextBox.Text
                };

                entities.Genres.Add(genre);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Genre oldGenre = entities.Genres.Find(currentGenre.Id);

                Genre newGenre = new Genre()
                {
                    Id = currentGenre.Id,
                    Name = genreTextBox.Text
                };

                entities.Entry(oldGenre).CurrentValues.SetValues(newGenre);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void ChangeGenreForm_Load(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                currentGenre = entities.Genres
                    .OrderBy(genre => genre.Id)
                    .First();
            }

            genreTextBox.Text = currentGenre.Name;
        }
    }
}
