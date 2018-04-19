using System.Collections.Generic;

namespace JobsList.Models
{
  public class JobVariables
  {
    private string _name;
    private string _date;
    private string _keyword;
    private string _other;
    private int _id;
    public static List<JobVariables> _instances = new List<JobVariables> {};

    public JobVariables(string name, string date, string keyword, string other)
    {
      _name = name;
      _date = date;
      _keyword = keyword;
      _other = other;
      _id = _instances.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetDate()
    {
      return _date;
    }
    public void SetDate(string newDate)
    {
      _date = newDate;
    }
    public string GetKeyword()
    {
      return _keyword;
    }
    public void SetKeyword(string newKeyword)
    {
      _keyword = newKeyword;
    }
    public string GetOther()
    {
      return _other;
    }
    public void SetOther(string newOther)
    {
      _other = newOther;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<JobVariables> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static JobVariables Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
