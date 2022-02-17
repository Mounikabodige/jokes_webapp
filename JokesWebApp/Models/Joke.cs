using System;
namespace JokesWebApp.Models
{
    public class Joke
    {
        public Joke()
        {

        }

        /// <summary>
        /// Gets or sets the joke identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the joke question.
        /// </summary>
        public string JokeQuestion { get; set; }

        /// <summary>
        /// Gets or sets the joke answer.
        /// </summary>
        public string JokeAnswer { get; set; }
    }
}
