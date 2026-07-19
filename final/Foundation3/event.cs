using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date} | Time: {_time}\nLocation: {_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
      return $"Event Type: {_eventType}\n{GetStandardDetails()}";
    }

    public string GetShortDescription()
    {
      return $"Type: {_eventType} | Title: {_title} | Date: {_date}";
    }
}
