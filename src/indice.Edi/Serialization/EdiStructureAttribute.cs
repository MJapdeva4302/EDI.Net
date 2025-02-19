namespace indice.Edi.Serialization;

/// <summary>
/// Base class for all structure difining attributes 
/// </summary>
public abstract class EdiStructureAttribute : EdiAttribute
{
    private bool _Mandatory;
    private bool _Required;
    private bool _Dependent;
    private bool _Recommended;
    private bool _Optional;
    private bool _NotUsed;
    private string _Description;

    /// <summary>
    /// Indicates that the current structure (Segment or Element) is mandatory or optional. By default this is false.
    /// </summary>
    public bool Mandatory {
        get { return _Mandatory; }
        set { _Mandatory = value; }
    }

    /// <summary>
    /// Indicates that the current structure (Segment or Element) is conditional but MUST be used anyway. By default this is false.
    /// </summary>
    public bool Required {
        get { return _Required; }
        set { _Required = value; }
    }

    /// <summary>
    /// Indicates that the current structure (Segment or Element) is conditional and its use depends on some condition. This condition must be clarified in the description. By default this is false.
    /// </summary>
    public bool Dependent {
        get { return _Dependent; }
        set { _Dependent = value; }
    }

    /// <summary>
    /// Indicates that the current structure (Segment or Element) is conditional and its use is recommended. By default this is false.
    /// </summary>
    public bool Recommended {
        get { return _Recommended; }
        set { _Recommended = value; }
    }

    /// <summary>
    /// Indicates that the current structure (Segment or Element) is conditional and its use is optional at the discretion of the sender. By default this is false.
    /// </summary>
    public bool Optional {
        get { return _Optional; }
        set { _Optional = value; }
    }

    /// <summary>
    /// Indicates that the current structure (Segment or Element) the segment must not be used. By default this is false.
    /// </summary>
    public bool NotUsed {
        get { return _NotUsed; }
        set { _NotUsed = value; }
    }

    /// <summary>
    /// Helps by annotating the current member with a <see cref="Description"/>. Only for reference and documentation.
    /// </summary>
    public string Description {
        get { return _Description; }
        set { _Description = value; }
    }
}
