﻿using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

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
                _console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Exisiting Content\n" +
                    "6. Exit");

                string input = _console.ReadLine();

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
                        _console.WriteLine("Please enter a valid option.");
                        break;
                }
                _console.WriteLine("Please press any key to continue.");
                _console.ReadKey();
                _console.Clear();
            }
        }
        private void CreateNewContent()
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            // Title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            // Description
            _console.WriteLine("Enter the description of the content.");
            newContent.Description = _console.ReadLine();

            // Star Rating
            _console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0).");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            // GenreType
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine());

            // MaturityRating
            _console.WriteLine("Enter the Maturity Rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                _console.WriteLine("The content was added correctly.");
            }
            else
            {
                _console.WriteLine("Could not add the content.");
            }
        }

        private void DisplayAllContent() // Display all content in the directory
        {
            _console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                // _console.ForegroundColor = ConsoleColor.Green;
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                // _console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // get a title from the user then display all properties of the content that has that title.
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the the title for the content you would like to see.");
            StreamingContent contentToDisplay = _repo.GetContentByTitle(_console.ReadLine());

            if (contentToDisplay != null)
            {
                _console.WriteLine($"Title: {contentToDisplay.Title}\n" +
                    $"Description: {contentToDisplay.Description}\n" +
                    $"Stars: {contentToDisplay.StarRating}\n" +
                    $"Genre: {contentToDisplay.TypeOfGenre}\n" +
                    $"Maturity Rating: {contentToDisplay.MaturityRating}\n" +
                    $"Is Family Friendly: {contentToDisplay.IsFamilyFriendly}\n");
            }
            else
            {
                _console.WriteLine("There is no content by that title.");
            }
        }

        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the content you would like to update.");

            string oldTitle = _console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            // Title
            _console.WriteLine("What is the title for this content?");
            newContent.Title = _console.ReadLine();

            // Description
            _console.WriteLine("Enter the description of the content.");
            newContent.Description = _console.ReadLine();

            // Star Rating
            _console.WriteLine("Enter the Star Rating for this content (0.0 - 5.0).");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            // GenreType
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine());

            // MaturityRating
            _console.WriteLine("Enter the Maturity Rating for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. TV-G\n" +
                "6. TV-PG\n" +
                "7. TV-14\n" +
                "8. TV-MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated == true)
            {
                _console.WriteLine("The content was updated successfully.");
            }
            else
            {
                _console.WriteLine("No content by that title exists.");
            }
        }

        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());

            if (wasDeleted)
            {
                _console.WriteLine("Your content was successfully deleted.");
            }
            else
            {
                _console.WriteLine("Content could not be deleted.");
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
