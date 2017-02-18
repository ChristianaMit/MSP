using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance{
public abstract class Book{
	public string title;
	public abstract void setTitle(string s);
	public string getTitle(){
		return title;
	}
}

public class MyBook: Book{
    public override void setTitle(string s){
    	string title= null;
		title = s;    
    }    
}

class PrintTitle{	
	static void Main(String[] args) {		
		//string title=Console.ReadLine();
		string title = "This is it";
		MyBook new_novel=new MyBook();
		new_novel.setTitle(title);
		Console.WriteLine("The title is: {0} ", new_novel.getTitle());		
	}
}

}