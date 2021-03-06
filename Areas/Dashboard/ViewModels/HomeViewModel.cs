using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace QuizNSwap.Areas.Dashboard.ViewModels
{
    public class HomeViewModel
    {
        public List<Folder> Folders { get; set; } = new List<Folder>();
        public List<Topic> Topics { get; set; } = new List<Topic>();

        [Required] // for the creation of new folder, probably getting rid of it after delegating this to API controller 
        public string FolderName { get; set; }
        
        public bool Empty 
        { 
            get 
            { 
                return FoldersEmpty && TopicsEmpty; 
            } 
        } 

        public bool FoldersEmpty
        {
            get
            {
                return Folders.Count == 0;
            }
        }

        public bool TopicsEmpty
        {
            get
            {
                return Topics.Count == 0;
            }
        }

        public class Folder
        {
            public int Id { get; set; } // for redirection
            public string Name {get;set;}
            public int TopicCount {get; set;}

            public static implicit operator Folder(QuizNSwap.Data.Models.Folder dbFolder)
            {
                return new Folder
                {
                    Name = dbFolder.Name,
                    //TopicCount = dbFolder.Topics.Count;
                };
            }
        } 

        public class Topic
        {
            public int Id { get; set; } // for redirection
            public string Name { get; set; }
            public int QuestionCardCount { get; set; }

            public static implicit operator Topic(QuizNSwap.Data.Models.Topic dbTopic)
            {
                return new Topic
                {
                    Name = dbTopic.Name,
                    QuestionCardCount = dbTopic.QuestionCards.Count
                };
            }
        }

    }
}
