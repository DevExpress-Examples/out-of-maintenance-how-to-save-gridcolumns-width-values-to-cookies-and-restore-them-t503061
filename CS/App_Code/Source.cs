using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Source
/// </summary>
public class Source {
    const int count = 5;
    public List<Category> PopulateList() {
        List<Category> list = new List<Category>();
        for(int i = 0; i < 5; i++) {
            list.Add(new Category() { CategoryID = i, CategoryName = "Name" + i, Description = "Description" + i });
        }
        return list;
    }
}