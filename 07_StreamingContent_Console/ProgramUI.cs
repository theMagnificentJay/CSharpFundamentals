using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning == true)
            {
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Exisiting Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        // CreateNewContent
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        // ViewAllContent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        // ViewContentByTitle
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        // UpdateExistingContent
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        // DeleteExistingContent
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        // Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the description of the content.");
            newContent.Description = Console.ReadLine();

            // Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0).");
            newContent.StarRating = Convert.ToDouble(Console.ReadLine());

            // GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine());

            // MaturityRating
            Console.WriteLine("Enter the Maturity Rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly.");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() // Display all content in the directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // get a title from the user then display all properties of the content that has that title.
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the the title for the content you would like to see.");
            StreamingContent contentToDisplay = _repo.GetContentByTitle(Console.ReadLine());

            if (contentToDisplay != null)
            {
                Console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                    $"Description: {contentToDisplay.Description}\n" +
                    $"Stars: {contentToDisplay.StarRating}\n" +
                    $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                    $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                    $"Is Family Friendly: {contentToDisplay.IsFamilyFriendly}\n");
            }
            else
            {
                Console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update.");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            // Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            // Description
            Console.WriteLine("Enter the description of the content.");
            newContent.Description = Console.ReadLine();

            // Star Rating
            Console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0).");
            newContent.StarRating = Convert.ToDouble(Console.ReadLine());

            // GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine());

            // MaturityRating
            Console.WriteLine("Enter the Maturity Rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if(wasUpdated == true)
            {
                Console.WriteLine("The content was updated successfully.");
            }
            else
            {
                Console.WriteLine("No content by that title exists.");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets accidently transported back in time 30 years.", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar jar saves the day.", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and goes on a killing spree.", 1, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}
