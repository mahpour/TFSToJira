﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class CheckinEvent
{

    private string allChangesIncludedField;

    private string subscriberField;

    private string checkinInformationField;

    private string ownerField;

    private string creationDateField;

    private string commentField;

    private string timeZoneField;

    private string timeZoneOffsetField;

    private string teamProjectField;

    private string policyOverrideCommentField;

    private string policyFailuresField;

    private string titleField;

    private string contentTitleField;

    private string committerField;

    private string numberField;

    private CheckinEventCheckinNotesCheckinNote[][] checkinNotesField;

    private CheckinEventArtifactsArtifact[][] artifactsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string AllChangesIncluded
    {
        get
        {
            return this.allChangesIncludedField;
        }
        set
        {
            this.allChangesIncludedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Subscriber
    {
        get
        {
            return this.subscriberField;
        }
        set
        {
            this.subscriberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CheckinInformation
    {
        get
        {
            return this.checkinInformationField;
        }
        set
        {
            this.checkinInformationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CreationDate
    {
        get
        {
            return this.creationDateField;
        }
        set
        {
            this.creationDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TimeZone
    {
        get
        {
            return this.timeZoneField;
        }
        set
        {
            this.timeZoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TimeZoneOffset
    {
        get
        {
            return this.timeZoneOffsetField;
        }
        set
        {
            this.timeZoneOffsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TeamProject
    {
        get
        {
            return this.teamProjectField;
        }
        set
        {
            this.teamProjectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PolicyOverrideComment
    {
        get
        {
            return this.policyOverrideCommentField;
        }
        set
        {
            this.policyOverrideCommentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string PolicyFailures
    {
        get
        {
            return this.policyFailuresField;
        }
        set
        {
            this.policyFailuresField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ContentTitle
    {
        get
        {
            return this.contentTitleField;
        }
        set
        {
            this.contentTitleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Committer
    {
        get
        {
            return this.committerField;
        }
        set
        {
            this.committerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("CheckinNote", typeof(CheckinEventCheckinNotesCheckinNote), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public CheckinEventCheckinNotesCheckinNote[][] CheckinNotes
    {
        get
        {
            return this.checkinNotesField;
        }
        set
        {
            this.checkinNotesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Artifact", typeof(CheckinEventArtifactsArtifact), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    public CheckinEventArtifactsArtifact[][] Artifacts
    {
        get
        {
            return this.artifactsField;
        }
        set
        {
            this.artifactsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CheckinEventCheckinNotesCheckinNote
{

    private string nameField;

    private string valField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string val
    {
        get
        {
            return this.valField;
        }
        set
        {
            this.valField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class CheckinEventArtifactsArtifact
{

    private string urlField;

    private string artifactTypeField;

    private string serverItemField;

    private string itemField;

    private string folderField;

    private string teamProjectField;

    private string itemRevisionField;

    private string changeTypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ArtifactType
    {
        get
        {
            return this.artifactTypeField;
        }
        set
        {
            this.artifactTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ServerItem
    {
        get
        {
            return this.serverItemField;
        }
        set
        {
            this.serverItemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Folder
    {
        get
        {
            return this.folderField;
        }
        set
        {
            this.folderField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TeamProject
    {
        get
        {
            return this.teamProjectField;
        }
        set
        {
            this.teamProjectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemRevision
    {
        get
        {
            return this.itemRevisionField;
        }
        set
        {
            this.itemRevisionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ChangeType
    {
        get
        {
            return this.changeTypeField;
        }
        set
        {
            this.changeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class NewDataSet
{

    private CheckinEvent[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CheckinEvent")]
    public CheckinEvent[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}
