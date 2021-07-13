using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SL_Cars_v2.Models
{
    class ActionDictionaryModel
    {
        private Dictionary<string, ActionModel> actions = new Dictionary<string, ActionModel>();


        public void AddExtraActions(params ActionModel[] possibleActions)
        {
            int counter = 0;
            if (actions.Any())
            {
                counter = Convert.ToInt32(actions.Keys.Last()) + 1;
            }
            foreach (var action in possibleActions)
            {
                actions.Add(action.Key ?? counter.ToString(), action);
                counter++;
            }
        }
        public void SetActions(params ActionModel[] possibleActions)
        {
            actions.Clear();

            int counter = 0;
            foreach (var action in possibleActions)
            {
                actions.Add(action.Key?? counter.ToString(), action);
                counter++;
            }
        }

        public void DisplayAllActionsInfo()
        {
            foreach (var action in actions)
            {
                Console.WriteLine($"{action.Key} - {action.Value.TextInfo}");
            }
            Console.WriteLine();
        }

        public void MakeAction()
        {
            string userChoise = KeywordHandlerService.OneElementHandler(actions.Keys.ToList());
            actions[userChoise].Action();
        } 
    }
}
