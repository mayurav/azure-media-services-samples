// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 2.1.3314.24787
//    <NameSpace>Microsoft.SilverlightMediaFramework.Plugins.Advertising.MAST</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings>
//  <auto-generated>
// ------------------------------------------------------------------------------
namespace Microsoft.SilverlightMediaFramework.Plugins.Advertising.MAST
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Microsoft.SilverlightMediaFramework.Plugins.Primitives.Advertising;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://openvideoplayer.sf.net/mast")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://openvideoplayer.sf.net/mast", IsNullable = false)]
    public partial class MAST : System.ComponentModel.INotifyPropertyChanged
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Trigger> triggersField;

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public MAST()
        {
            if ((this.triggersField == null))
            {
                this.triggersField = new List<Trigger>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("trigger", IsNullable = false)]
        public List<Trigger> triggers
        {
            get
            {
                return this.triggersField;
            }
            set
            {
                if ((this.triggersField != null))
                {
                    if ((triggersField.Equals(value) != true))
                    {
                        this.triggersField = value;
                        this.OnPropertyChanged("triggers");
                    }
                }
                else
                {
                    this.triggersField = value;
                    this.OnPropertyChanged("triggers");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Serializes current MAST object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            xmlSerializer.Serialize(memoryStream, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Deserializes workflow markup into an MAST object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output MAST object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out MAST obj, out System.Exception exception)
        {
            exception = null;
            obj = null;
            try
            {
                System.IO.StringReader stringReader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlTextReader = System.Xml.XmlReader.Create(stringReader);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(MAST));
                obj = ((MAST)(xmlSerializer.Deserialize(xmlTextReader)));
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public partial class Trigger : System.ComponentModel.INotifyPropertyChanged, IAdSequencingTrigger
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Condition> startConditionsField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Condition> endConditionsField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Source> sourcesField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string idField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string descriptionField;

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public Trigger()
        {
            if ((this.sourcesField == null))
            {
                this.sourcesField = new List<Source>();
            }
            if ((this.endConditionsField == null))
            {
                this.endConditionsField = new List<Condition>();
            }
            if ((this.startConditionsField == null))
            {
                this.startConditionsField = new List<Condition>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("condition", IsNullable = false)]
        public List<Condition> startConditions
        {
            get
            {
                return this.startConditionsField;
            }
            set
            {
                if ((this.startConditionsField != null))
                {
                    if ((startConditionsField.Equals(value) != true))
                    {
                        this.startConditionsField = value;
                        this.OnPropertyChanged("startConditions");
                    }
                }
                else
                {
                    this.startConditionsField = value;
                    this.OnPropertyChanged("startConditions");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("condition", IsNullable = false)]
        public List<Condition> endConditions
        {
            get
            {
                return this.endConditionsField;
            }
            set
            {
                if ((this.endConditionsField != null))
                {
                    if ((endConditionsField.Equals(value) != true))
                    {
                        this.endConditionsField = value;
                        this.OnPropertyChanged("endConditions");
                    }
                }
                else
                {
                    this.endConditionsField = value;
                    this.OnPropertyChanged("endConditions");
                }
            }
        }

        [XmlIgnore]
        public IEnumerable<IAdSequencingSource> Sources { get { return sources.Cast<IAdSequencingSource>(); } }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("source", IsNullable = false)]
        public List<Source> sources
        {
            get
            {
                return this.sourcesField;
            }
            set
            {
                if ((this.sourcesField != null))
                {
                    if ((sourcesField.Equals(value) != true))
                    {
                        this.sourcesField = value;
                        this.OnPropertyChanged("sources");
                    }
                }
                else
                {
                    this.sourcesField = value;
                    this.OnPropertyChanged("sources");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("description")]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Serializes current Trigger object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            xmlSerializer.Serialize(memoryStream, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Deserializes workflow markup into an Trigger object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output Trigger object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Trigger obj, out System.Exception exception)
        {
            exception = null;
            obj = null;
            try
            {
                System.IO.StringReader stringReader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlTextReader = System.Xml.XmlReader.Create(stringReader);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Trigger));
                obj = ((Trigger)(xmlSerializer.Deserialize(xmlTextReader)));
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public partial class Condition : System.ComponentModel.INotifyPropertyChanged
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Condition> conditionField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private ConditionType typeField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool typeFieldSpecified;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string nameField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string valueField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private Operator operatorField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private bool operatorFieldSpecified;

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public Condition()
        {
            if ((this.conditionField == null))
            {
                this.conditionField = new List<Condition>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("condition")]
        public List<Condition> condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                if ((this.conditionField != null))
                {
                    if ((conditionField.Equals(value) != true))
                    {
                        this.conditionField = value;
                        this.OnPropertyChanged("condition");
                    }
                }
                else
                {
                    this.conditionField = value;
                    this.OnPropertyChanged("condition");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ConditionType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if (typeField != value)
                {
                    this.typeField = value;
                    this.OnPropertyChanged("type");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                if ((typeFieldSpecified.Equals(value) != true))
                {
                    this.typeFieldSpecified = value;
                    this.OnPropertyChanged("typeSpecified");
                }
            }
        }

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
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("name");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("value");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Operator @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                if (operatorField != value)
                {
                    this.operatorField = value;
                    this.OnPropertyChanged("operator");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool operatorSpecified
        {
            get
            {
                return this.operatorFieldSpecified;
            }
            set
            {
                if ((operatorFieldSpecified.Equals(value) != true))
                {
                    this.operatorFieldSpecified = value;
                    this.OnPropertyChanged("operatorSpecified");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Serializes current Condition object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            xmlSerializer.Serialize(memoryStream, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Deserializes workflow markup into an Condition object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output Condition object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Condition obj, out System.Exception exception)
        {
            exception = null;
            obj = null;
            try
            {
                System.IO.StringReader stringReader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlTextReader = System.Xml.XmlReader.Create(stringReader);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Condition));
                obj = ((Condition)(xmlSerializer.Deserialize(xmlTextReader)));
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public enum ConditionType
    {

        /// <remarks/>
        property,

        /// <remarks/>
        @event,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public enum Operator
    {

        /// <remarks/>
        EQ,

        /// <remarks/>
        NEQ,

        /// <remarks/>
        GTR,

        /// <remarks/>
        GEQ,

        /// <remarks/>
        LT,

        /// <remarks/>
        LEQ,

        /// <remarks/>
        MOD,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public partial class Target : System.ComponentModel.INotifyPropertyChanged, IAdSequencingTarget
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Target> targetField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string regionField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string typeField;

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public Target()
        {
            if ((this.targetField == null))
            {
                this.targetField = new List<Target>();
            }
        }

        [XmlIgnore]
        public IEnumerable<IAdSequencingTarget> Targets { get { return target.Cast<IAdSequencingTarget>(); } }
        [XmlIgnore]
        public object Instance { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("target")]
        public List<Target> target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                if ((this.targetField != null))
                {
                    if ((targetField.Equals(value) != true))
                    {
                        this.targetField = value;
                        this.OnPropertyChanged("target");
                    }
                }
                else
                {
                    this.targetField = value;
                    this.OnPropertyChanged("target");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("region")]
        public string Region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                if ((this.regionField != null))
                {
                    if ((regionField.Equals(value) != true))
                    {
                        this.regionField = value;
                        this.OnPropertyChanged("Region");
                    }
                }
                else
                {
                    this.regionField = value;
                    this.OnPropertyChanged("Region");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if ((this.typeField != null))
                {
                    if ((typeField.Equals(value) != true))
                    {
                        this.typeField = value;
                        this.OnPropertyChanged("Type");
                    }
                }
                else
                {
                    this.typeField = value;
                    this.OnPropertyChanged("Type");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Serializes current Target object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            xmlSerializer.Serialize(memoryStream, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Deserializes workflow markup into an Target object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output Target object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Target obj, out System.Exception exception)
        {
            exception = null;
            obj = null;
            try
            {
                System.IO.StringReader stringReader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlTextReader = System.Xml.XmlReader.Create(stringReader);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Target));
                obj = ((Target)(xmlSerializer.Deserialize(xmlTextReader)));
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3082")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://openvideoplayer.sf.net/mast")]
    public partial class Source : System.ComponentModel.INotifyPropertyChanged, IAdSequencingSource
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Source> sourcesField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private List<Target> targetsField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string uriField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string altReferenceField;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string formatField;

        /// <summary>
        /// .ctor class constructor
        /// </summary>
        public Source()
        {
            if ((this.targetsField == null))
            {
                this.targetsField = new List<Target>();
            }
            if ((this.sourcesField == null))
            {
                this.sourcesField = new List<Source>();
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sources", IsNullable = false)]
        public List<Source> sources
        {
            get
            {
                return this.sourcesField;
            }
            set
            {
                if ((this.sourcesField != null))
                {
                    if ((sourcesField.Equals(value) != true))
                    {
                        this.sourcesField = value;
                        this.OnPropertyChanged("sources");
                    }
                }
                else
                {
                    this.sourcesField = value;
                    this.OnPropertyChanged("sources");
                }
            }
        }

        [XmlIgnore]
        public IEnumerable<IAdSequencingTarget> Targets { get { return targets.Cast<IAdSequencingTarget>(); } }

        [XmlIgnore]
        public IEnumerable<IAdSequencingSource> Sources { get { return sources.Cast<IAdSequencingSource>(); } }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("target", IsNullable = false)]
        public List<Target> targets
        {
            get
            {
                return this.targetsField;
            }
            set
            {
                if ((this.targetsField != null))
                {
                    if ((targetsField.Equals(value) != true))
                    {
                        this.targetsField = value;
                        this.OnPropertyChanged("targets");
                    }
                }
                else
                {
                    this.targetsField = value;
                    this.OnPropertyChanged("targets");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("uri", DataType = "anyURI")]
        public string Uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                if ((this.uriField != null))
                {
                    if ((uriField.Equals(value) != true))
                    {
                        this.uriField = value;
                        this.OnPropertyChanged("Uri");
                    }
                }
                else
                {
                    this.uriField = value;
                    this.OnPropertyChanged("Uri");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("altReference")]
        public string AltReference
        {
            get
            {
                return this.altReferenceField;
            }
            set
            {
                if ((this.altReferenceField != null))
                {
                    if ((altReferenceField.Equals(value) != true))
                    {
                        this.altReferenceField = value;
                        this.OnPropertyChanged("AltReference");
                    }
                }
                else
                {
                    this.altReferenceField = value;
                    this.OnPropertyChanged("AltReference");
                }
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("format")]
        public string Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                if ((this.formatField != null))
                {
                    if ((formatField.Equals(value) != true))
                    {
                        this.formatField = value;
                        this.OnPropertyChanged("Format");
                    }
                }
                else
                {
                    this.formatField = value;
                    this.OnPropertyChanged("Format");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }

        /// <summary>
        /// Serializes current Source object into an XML document
        /// </summary>
        // <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            xmlSerializer.Serialize(memoryStream, this);
            memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
            System.IO.StreamReader streamReader = new System.IO.StreamReader(memoryStream);
            return streamReader.ReadToEnd();
        }

        /// <summary>
        /// Deserializes workflow markup into an Source object
        /// </summary>
        // <param name="xml">string workflow markup to deserialize</param>
        // <param name="obj">Output Source object</param>
        // <param name="exception">output Exception value if deserialize failed</param>
        // <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Source obj, out System.Exception exception)
        {
            exception = null;
            obj = null;
            try
            {
                System.IO.StringReader stringReader = new System.IO.StringReader(xml);
                System.Xml.XmlReader xmlTextReader = System.Xml.XmlReader.Create(stringReader);
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Source));
                obj = ((Source)(xmlSerializer.Deserialize(xmlTextReader)));
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }
    }
}
