using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_ListType
{

	/// <summary>
	/// Student class for this example
	/// </summary>
	public class Student
	{
		public string StudentId
		{ get; set; }
		public string StudentName
		{ get; set; } 
		public int StudentAge
		{ get; set; }
		public string StudentGender
		{ get; set; } 
		public double StudentScore
		{ get; set; } 
		
		#region Constructors
		public Student() { }
		public Student(string id, string name, int age, string gender, double score)
		{
			this.StudentId = id;
			this.StudentName = name;
			this.StudentAge = age;
			this.StudentGender = gender;
			this.StudentScore = score;
		}
		#endregion
		#region interfaceMethod
		public int CompareTo(Student other)
		{
			return this.StudentId.CompareTo(other.StudentId);
			throw new NotImplementedException();
		}
        #endregion
       
    }
	/// <summary>
	/// import Icomparer for Sort function
	/// this class is for sort data by StudentID by Asc order
	/// </summary>
	class studentIdAsc : IComparer<Student>
	{
		public int Compare(Student x, Student y)
		{
			return x.StudentId.CompareTo(y.StudentId);
		}
	}
	/// <summary>
	/// import Icomparer for Sort function
	/// this class is for sort data by StudentScore by Desc order
	/// </summary>
	class studentScoreDesc : IComparer<Student>
	{
		public int Compare(Student x, Student y)
		{
			return y.StudentScore.CompareTo(x.StudentScore);
		}
	}
}
