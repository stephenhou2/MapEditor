// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: output/proto/HeroDataCfg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TableProto {

  /// <summary>Holder for reflection information generated from output/proto/HeroDataCfg.proto</summary>
  public static partial class HeroDataCfgReflection {

    #region Descriptor
    /// <summary>File descriptor for output/proto/HeroDataCfg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeroDataCfgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5vdXRwdXQvcHJvdG8vSGVyb0RhdGFDZmcucHJvdG8SClRhYmxlUHJvdG8i",
            "twEKC0hlcm9EYXRhQ2ZnEgoKAklEGAEgASgFEgwKBE5BTUUYAiABKAkSFAoM",
            "QmFzZVN0cmVuZ3RoGAMgASgFEhYKDlN0cmVuZ3RoR3Jvd3RoGAQgASgFEhMK",
            "C0Jhc2VBZ2lsaXR5GAUgASgFEhUKDUFnaWxpdHlHcm93dGgYBiABKAUSGAoQ",
            "QmFzZUludGVsbGlnZW5jZRgHIAEoBRIaChJJbnRlbGxpZ2VuY2VHcm93dGgY",
            "CCABKAUiNwoOVEJfSGVyb0RhdGFDZmcSJQoEZGF0YRgBIAMoCzIXLlRhYmxl",
            "UHJvdG8uSGVyb0RhdGFDZmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TableProto.HeroDataCfg), global::TableProto.HeroDataCfg.Parser, new[]{ "ID", "NAME", "BaseStrength", "StrengthGrowth", "BaseAgility", "AgilityGrowth", "BaseIntelligence", "IntelligenceGrowth" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TableProto.TB_HeroDataCfg), global::TableProto.TB_HeroDataCfg.Parser, new[]{ "Data" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HeroDataCfg : pb::IMessage<HeroDataCfg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HeroDataCfg> _parser = new pb::MessageParser<HeroDataCfg>(() => new HeroDataCfg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HeroDataCfg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TableProto.HeroDataCfgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroDataCfg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroDataCfg(HeroDataCfg other) : this() {
      iD_ = other.iD_;
      nAME_ = other.nAME_;
      baseStrength_ = other.baseStrength_;
      strengthGrowth_ = other.strengthGrowth_;
      baseAgility_ = other.baseAgility_;
      agilityGrowth_ = other.agilityGrowth_;
      baseIntelligence_ = other.baseIntelligence_;
      intelligenceGrowth_ = other.intelligenceGrowth_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HeroDataCfg Clone() {
      return new HeroDataCfg(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private int iD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ID {
      get { return iD_; }
      set {
        iD_ = value;
      }
    }

    /// <summary>Field number for the "NAME" field.</summary>
    public const int NAMEFieldNumber = 2;
    private string nAME_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NAME {
      get { return nAME_; }
      set {
        nAME_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "BaseStrength" field.</summary>
    public const int BaseStrengthFieldNumber = 3;
    private int baseStrength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BaseStrength {
      get { return baseStrength_; }
      set {
        baseStrength_ = value;
      }
    }

    /// <summary>Field number for the "StrengthGrowth" field.</summary>
    public const int StrengthGrowthFieldNumber = 4;
    private int strengthGrowth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StrengthGrowth {
      get { return strengthGrowth_; }
      set {
        strengthGrowth_ = value;
      }
    }

    /// <summary>Field number for the "BaseAgility" field.</summary>
    public const int BaseAgilityFieldNumber = 5;
    private int baseAgility_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BaseAgility {
      get { return baseAgility_; }
      set {
        baseAgility_ = value;
      }
    }

    /// <summary>Field number for the "AgilityGrowth" field.</summary>
    public const int AgilityGrowthFieldNumber = 6;
    private int agilityGrowth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AgilityGrowth {
      get { return agilityGrowth_; }
      set {
        agilityGrowth_ = value;
      }
    }

    /// <summary>Field number for the "BaseIntelligence" field.</summary>
    public const int BaseIntelligenceFieldNumber = 7;
    private int baseIntelligence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BaseIntelligence {
      get { return baseIntelligence_; }
      set {
        baseIntelligence_ = value;
      }
    }

    /// <summary>Field number for the "IntelligenceGrowth" field.</summary>
    public const int IntelligenceGrowthFieldNumber = 8;
    private int intelligenceGrowth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntelligenceGrowth {
      get { return intelligenceGrowth_; }
      set {
        intelligenceGrowth_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HeroDataCfg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HeroDataCfg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (NAME != other.NAME) return false;
      if (BaseStrength != other.BaseStrength) return false;
      if (StrengthGrowth != other.StrengthGrowth) return false;
      if (BaseAgility != other.BaseAgility) return false;
      if (AgilityGrowth != other.AgilityGrowth) return false;
      if (BaseIntelligence != other.BaseIntelligence) return false;
      if (IntelligenceGrowth != other.IntelligenceGrowth) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ID != 0) hash ^= ID.GetHashCode();
      if (NAME.Length != 0) hash ^= NAME.GetHashCode();
      if (BaseStrength != 0) hash ^= BaseStrength.GetHashCode();
      if (StrengthGrowth != 0) hash ^= StrengthGrowth.GetHashCode();
      if (BaseAgility != 0) hash ^= BaseAgility.GetHashCode();
      if (AgilityGrowth != 0) hash ^= AgilityGrowth.GetHashCode();
      if (BaseIntelligence != 0) hash ^= BaseIntelligence.GetHashCode();
      if (IntelligenceGrowth != 0) hash ^= IntelligenceGrowth.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ID);
      }
      if (NAME.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NAME);
      }
      if (BaseStrength != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BaseStrength);
      }
      if (StrengthGrowth != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(StrengthGrowth);
      }
      if (BaseAgility != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BaseAgility);
      }
      if (AgilityGrowth != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(AgilityGrowth);
      }
      if (BaseIntelligence != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(BaseIntelligence);
      }
      if (IntelligenceGrowth != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(IntelligenceGrowth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ID != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ID);
      }
      if (NAME.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NAME);
      }
      if (BaseStrength != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BaseStrength);
      }
      if (StrengthGrowth != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(StrengthGrowth);
      }
      if (BaseAgility != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BaseAgility);
      }
      if (AgilityGrowth != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(AgilityGrowth);
      }
      if (BaseIntelligence != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(BaseIntelligence);
      }
      if (IntelligenceGrowth != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(IntelligenceGrowth);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ID);
      }
      if (NAME.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NAME);
      }
      if (BaseStrength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseStrength);
      }
      if (StrengthGrowth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StrengthGrowth);
      }
      if (BaseAgility != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseAgility);
      }
      if (AgilityGrowth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AgilityGrowth);
      }
      if (BaseIntelligence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseIntelligence);
      }
      if (IntelligenceGrowth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntelligenceGrowth);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HeroDataCfg other) {
      if (other == null) {
        return;
      }
      if (other.ID != 0) {
        ID = other.ID;
      }
      if (other.NAME.Length != 0) {
        NAME = other.NAME;
      }
      if (other.BaseStrength != 0) {
        BaseStrength = other.BaseStrength;
      }
      if (other.StrengthGrowth != 0) {
        StrengthGrowth = other.StrengthGrowth;
      }
      if (other.BaseAgility != 0) {
        BaseAgility = other.BaseAgility;
      }
      if (other.AgilityGrowth != 0) {
        AgilityGrowth = other.AgilityGrowth;
      }
      if (other.BaseIntelligence != 0) {
        BaseIntelligence = other.BaseIntelligence;
      }
      if (other.IntelligenceGrowth != 0) {
        IntelligenceGrowth = other.IntelligenceGrowth;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ID = input.ReadInt32();
            break;
          }
          case 18: {
            NAME = input.ReadString();
            break;
          }
          case 24: {
            BaseStrength = input.ReadInt32();
            break;
          }
          case 32: {
            StrengthGrowth = input.ReadInt32();
            break;
          }
          case 40: {
            BaseAgility = input.ReadInt32();
            break;
          }
          case 48: {
            AgilityGrowth = input.ReadInt32();
            break;
          }
          case 56: {
            BaseIntelligence = input.ReadInt32();
            break;
          }
          case 64: {
            IntelligenceGrowth = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ID = input.ReadInt32();
            break;
          }
          case 18: {
            NAME = input.ReadString();
            break;
          }
          case 24: {
            BaseStrength = input.ReadInt32();
            break;
          }
          case 32: {
            StrengthGrowth = input.ReadInt32();
            break;
          }
          case 40: {
            BaseAgility = input.ReadInt32();
            break;
          }
          case 48: {
            AgilityGrowth = input.ReadInt32();
            break;
          }
          case 56: {
            BaseIntelligence = input.ReadInt32();
            break;
          }
          case 64: {
            IntelligenceGrowth = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TB_HeroDataCfg : pb::IMessage<TB_HeroDataCfg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TB_HeroDataCfg> _parser = new pb::MessageParser<TB_HeroDataCfg>(() => new TB_HeroDataCfg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TB_HeroDataCfg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TableProto.HeroDataCfgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_HeroDataCfg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_HeroDataCfg(TB_HeroDataCfg other) : this() {
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_HeroDataCfg Clone() {
      return new TB_HeroDataCfg(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<global::TableProto.HeroDataCfg> _repeated_data_codec
        = pb::FieldCodec.ForMessage(10, global::TableProto.HeroDataCfg.Parser);
    private readonly pbc::RepeatedField<global::TableProto.HeroDataCfg> data_ = new pbc::RepeatedField<global::TableProto.HeroDataCfg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::TableProto.HeroDataCfg> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TB_HeroDataCfg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TB_HeroDataCfg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!data_.Equals(other.data_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= data_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      data_.WriteTo(output, _repeated_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      data_.WriteTo(ref output, _repeated_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += data_.CalculateSize(_repeated_data_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TB_HeroDataCfg other) {
      if (other == null) {
        return;
      }
      data_.Add(other.data_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            data_.AddEntriesFrom(input, _repeated_data_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            data_.AddEntriesFrom(ref input, _repeated_data_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
