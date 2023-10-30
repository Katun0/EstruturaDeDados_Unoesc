using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyStructure;

class Program
{
    public static void Main(string[] args)
    {
        Tree<Person> company = new Tree<Person>();
        company.Root = new TreeNode<Person>()
        {
            Data = new Person(100, "Marcin Jamro", "CEO"),
            Parent = null
        };
        company.Root.Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(1, "John Smith", "Head of Development"),
                Parent = company.Root
            },
            new TreeNode<Person>()
            {
                Data = new Person (150, "Lily Smith", "Head of Sales"),
                Parent = company.Root
            }
        };
        company.Root.Children[1].Children = new List<TreeNode<Person>>()
        {
            new TreeNode<Person>()
            {
                Data = new Person(30, "Anthony Black", "Sales Specialist"),
                Parent = company.Root.Children[2]
            }
        };

    }

}