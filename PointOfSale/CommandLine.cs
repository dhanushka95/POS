using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    class CommandLine
    {
        /*this class can be use for show some message to user*/

       public CommandLine(string windowName)
        {
            
            switch (windowName)
            {
                case "RemoveProduct":
                    MainWindow.TaskBar = "you will able to remove the product details";
                    break;
                case "AddCategory":
                    MainWindow.TaskBar = "you will able to add the category details";
                    break;
                case "AddCompany":
                    MainWindow.TaskBar = "you will able to add the company details";
                    break;
                case "AddProduct":
                    MainWindow.TaskBar = "you will able to add the product details";
                    break;
                case "ChangeCategory":
                    MainWindow.TaskBar = "you will able to change the category details";
                    break;
                case "ChangeCompany":
                    MainWindow.TaskBar = "you will able to change the company details";
                    break;
                case "ChangeProduct":
                    MainWindow.TaskBar = "you will able to change the product details";
                    break;
                case "RemoveCategory":
                    MainWindow.TaskBar = "you will able to remove the category details";
                    break;
                case "RemoveCompany":
                    MainWindow.TaskBar = "you will able to remove the company details";
                    break;
                case "ServerConfiguration":
                    MainWindow.TaskBar = "you will able to configur the server details";
                    break;          
                case "AddStock":
                    MainWindow.TaskBar = "you will able to add the stock details";
                    break;

            }

        }

    }
}
