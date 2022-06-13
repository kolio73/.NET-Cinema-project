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
    public partial class ChangeMoviesForm : Form
    {
        private Movies currentMovie;
        public ChangeMoviesForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies()
            {
                Name = movieTextBox.Text,
                Projection = (int)projectionComboBox.SelectedValue,
                Genre = (int)genreComboBox.SelectedValue,
                Price = (int)priceNumericUpDown.Value
            };

            using (Entities entities = new Entities())
            {
                entities.Movies1.Add(movie);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Movies oldMovie = entities.Movies1.Find(currentMovie.Id);

                Movies newMovie = new Movies()
                {
                    Id = currentMovie.Id,
                    Name = movieTextBox.Text,
                    Projection = (int)projectionComboBox.SelectedValue,
                    Genre = (int)genreComboBox.SelectedValue,
                    Price = (int)priceNumericUpDown.Value
                };

                entities.Entry(oldMovie).CurrentValues.SetValues(newMovie);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (Entities entities = new Entities())
            {
                Movies movie = entities.Movies1.Find(currentMovie.Id);
                entities.Movies1.Remove(movie);
                entities.SaveChanges();
            }

            nextButton.PerformClick();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;

            using (Entities entities = new Entities())
            {
                List<Movies> prevMovies = entities.Movies1
                    .Where(movie => movie.Id < currentMovie.Id)
                    .OrderBy(movie => movie.Id)
                    .ToList();

                if (prevMovies.Count > 0)
                {
                    currentMovie = prevMovies.Last();
                    PopulateControls();
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
                List<Movies> nextMovies = entities.Movies1
                    .Where(movies => movies.Id > currentMovie.Id)
                    .OrderBy(movies => movies.Id)
                    .ToList();

                if (nextMovies.Count > 0)
                {
                    currentMovie = nextMovies.First();
                    PopulateControls();
                }
                else
                {
                    nextButton.Enabled = false;
                }
            }
        }
        private void PopulateControls()
        {
            movieTextBox.Text = currentMovie.Name;
            priceNumericUpDown.Value = currentMovie.Price;
            projectionComboBox.SelectedValue = currentMovie.Projection;
            genreComboBox.SelectedValue = currentMovie.Genre;
        }

        private void ChangeMoviesForm_Load(object sender, EventArgs e)
        {
            List<Projection> projections;
            List<Genre> genres;

            using (Entities entities = new Entities())
            {
                projections = entities.Projections.OrderBy(projection => projection.Id).ToList();
                genres = entities.Genres.OrderBy(genre => genre.Id).ToList();

                currentMovie = entities.Movies1.First();
            }

            projectionComboBox.ValueMember = "Id";
            projectionComboBox.DisplayMember = "Name";
            projectionComboBox.DataSource = projections;

            genreComboBox.ValueMember = "Id";
            genreComboBox.DisplayMember = "Name";
            genreComboBox.DataSource = genres;

            PopulateControls();
        }
    }
}
