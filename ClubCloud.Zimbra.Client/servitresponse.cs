/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.xmlsoap.org/soap/envelope/", IsNullable=false)]
public partial class Envelope {
    
    private EnvelopeBody bodyField;
    
    /// <remarks/>
    public EnvelopeBody Body {
        get {
            return this.bodyField;
        }
        set {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody {
    
    private ExecuteResponse executeResponseField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
    public ExecuteResponse ExecuteResponse {
        get {
            return this.executeResponseField;
        }
        set {
            this.executeResponseField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/crm/2007/WebServices", IsNullable=false)]
public partial class ExecuteResponse {
    
    private ExecuteResponseResponse responseField;
    
    /// <remarks/>
    public ExecuteResponseResponse Response {
        get {
            return this.responseField;
        }
        set {
            this.responseField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
public partial class ExecuteResponseResponse {
    
    private string userIdField;
    
    private string businessUnitIdField;
    
    private string organizationIdField;
    
    /// <remarks/>
    public string UserId {
        get {
            return this.userIdField;
        }
        set {
            this.userIdField = value;
        }
    }
    
    /// <remarks/>
    public string BusinessUnitId {
        get {
            return this.businessUnitIdField;
        }
        set {
            this.businessUnitIdField = value;
        }
    }
    
    /// <remarks/>
    public string OrganizationId {
        get {
            return this.organizationIdField;
        }
        set {
            this.organizationIdField = value;
        }
    }
}

