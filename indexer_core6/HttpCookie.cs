public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionaray;
    public DateTime Expiry { get; set; }
    public HttpCookie()
    {
        _dictionaray = new Dictionary<string, string>();
    }

    public string this[string key]
    {
        get
        {
            return _dictionaray[key];
        }
        set
        {
            _dictionaray[key] = value;
        }
    }
}
