namespace Ubl.V2.Pe.common
{
    /// <summary>
    ///  The set of possible reasons for an allowance or charge.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class AllowanceChargeReasonCodeType : CodeType
    {
        /// <summary>
        /// Allowance
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator AllowanceChargeReasonCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new AllowanceChargeReasonCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of possible ways in which communication can be made (eg. Phone, email, etc).
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class ChannelCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="ChannelCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ChannelCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ChannelCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  Distinction between CHIP and MAG STRIPE cards
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class ChipCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="ChipCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ChipCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ChipCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for classifying series 1 freight containers based on external dimensions, associated ratings and, where appropriate, the minimum internal and door opening dimensions for certain types of containers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class ContainerSizeTypeCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="ContainerSizeTypeCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ContainerSizeTypeCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new ContainerSizeTypeCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of countries of the world.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class CountryIdentificationCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="CountryIdentificationCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator CountryIdentificationCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new CountryIdentificationCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of world currencies.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class CurrencyCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="CurrencyCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator CurrencyCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new CurrencyCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of possible statuses of a document with regard to its original state.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class DocumentStatusCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="DocumentStatusCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator DocumentStatusCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new DocumentStatusCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The possible directions of latitude
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class LatitudeDirectionCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="LatitudeDirectionCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator LatitudeDirectionCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new LatitudeDirectionCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of possible statuses of a line in a transaction with regard to its original state.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class LineStatusCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="LineStatusCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator LineStatusCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new LineStatusCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The possible directions of longitude
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class LongitudeDirectionCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="LongitudeDirectionCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator LongitudeDirectionCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new LongitudeDirectionCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of valid arithmetic operators
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class OperatorCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="OperatorCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator OperatorCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new OperatorCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for Passengers, Types of Cargo, Packages and Packaging Materials (with Complementary Codes for Package Names)
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class PackagingTypeCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="PackagingTypeCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PackagingTypeCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new PackagingTypeCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of valid means of paying the debt incurred.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class PaymentMeansCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="PaymentMeansCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PaymentMeansCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new PaymentMeansCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for Trade and Transport Locations
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class PortCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="PortCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PortCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new PortCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of values that indicate the status of an OrderItem in relation to substitution, denoting an acceptable substitute in the Order, an original for which an alternative is offered in the Order Confirmation, or an original for which an actual replacement is advised in the Despatch Advice.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class SubstitutionStatusCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="SubstitutionStatusCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator SubstitutionStatusCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new SubstitutionStatusCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for Trade and Transport Status
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class TransportationStatusCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="TransportationStatusCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TransportationStatusCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new TransportationStatusCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for qualifying a type of equipment used in the transportation of goods.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class TransportEquipmentTypeCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="TransportEquipmentTypeCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TransportEquipmentTypeCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new TransportEquipmentTypeCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for modes of transport
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class TransportModeCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="TransportModeCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator TransportModeCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new TransportModeCodeType { Value = value };
        }
    }
    
    /// <summary>
    ///  The set of code values for Units of Measure Used in International Trade
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2")]
    public partial class UnitOfMeasureCodeType : CodeType
    {

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="UnitOfMeasureCodeType"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator UnitOfMeasureCodeType(System.String value)
        {
             return string.IsNullOrEmpty(value) ? null : new UnitOfMeasureCodeType { Value = value };
        }
    }
}
