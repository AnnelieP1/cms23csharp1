using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Classes_GettersAndSetters.Models;

internal class customer


{
	private string firstName;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value.Trim(); }
	}

	public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";
}