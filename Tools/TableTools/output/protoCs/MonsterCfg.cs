// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: output/proto/MonsterCfg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TableProto {

  /// <summary>Holder for reflection information generated from output/proto/MonsterCfg.proto</summary>
  public static partial class MonsterCfgReflection {

    #region Descriptor
    /// <summary>File descriptor for output/proto/MonsterCfg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterCfgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1vdXRwdXQvcHJvdG8vTW9uc3RlckNmZy5wcm90bxIKVGFibGVQcm90byI/",
            "CgpNb25zdGVyQ2ZnEgoKAklEGAEgASgFEgwKBE5BTUUYAiABKAkSCwoDQVRL",
            "GAMgASgFEgoKAkhQGAQgASgFIjUKDVRCX01vbnN0ZXJDZmcSJAoEZGF0YRgB",
            "IAMoCzIWLlRhYmxlUHJvdG8uTW9uc3RlckNmZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TableProto.MonsterCfg), global::TableProto.MonsterCfg.Parser, new[]{ "ID", "NAME", "ATK", "HP" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TableProto.TB_MonsterCfg), global::TableProto.TB_MonsterCfg.Parser, new[]{ "Data" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MonsterCfg : pb::IMessage<MonsterCfg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonsterCfg> _parser = new pb::MessageParser<MonsterCfg>(() => new MonsterCfg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonsterCfg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TableProto.MonsterCfgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterCfg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterCfg(MonsterCfg other) : this() {
      iD_ = other.iD_;
      nAME_ = other.nAME_;
      aTK_ = other.aTK_;
      hP_ = other.hP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterCfg Clone() {
      return new MonsterCfg(this);
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

    /// <summary>Field number for the "ATK" field.</summary>
    public const int ATKFieldNumber = 3;
    private int aTK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ATK {
      get { return aTK_; }
      set {
        aTK_ = value;
      }
    }

    /// <summary>Field number for the "HP" field.</summary>
    public const int HPFieldNumber = 4;
    private int hP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HP {
      get { return hP_; }
      set {
        hP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonsterCfg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonsterCfg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (NAME != other.NAME) return false;
      if (ATK != other.ATK) return false;
      if (HP != other.HP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ID != 0) hash ^= ID.GetHashCode();
      if (NAME.Length != 0) hash ^= NAME.GetHashCode();
      if (ATK != 0) hash ^= ATK.GetHashCode();
      if (HP != 0) hash ^= HP.GetHashCode();
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
      if (ATK != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ATK);
      }
      if (HP != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HP);
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
      if (ATK != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ATK);
      }
      if (HP != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HP);
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
      if (ATK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ATK);
      }
      if (HP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonsterCfg other) {
      if (other == null) {
        return;
      }
      if (other.ID != 0) {
        ID = other.ID;
      }
      if (other.NAME.Length != 0) {
        NAME = other.NAME;
      }
      if (other.ATK != 0) {
        ATK = other.ATK;
      }
      if (other.HP != 0) {
        HP = other.HP;
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
            ATK = input.ReadInt32();
            break;
          }
          case 32: {
            HP = input.ReadInt32();
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
            ATK = input.ReadInt32();
            break;
          }
          case 32: {
            HP = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TB_MonsterCfg : pb::IMessage<TB_MonsterCfg>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TB_MonsterCfg> _parser = new pb::MessageParser<TB_MonsterCfg>(() => new TB_MonsterCfg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TB_MonsterCfg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TableProto.MonsterCfgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_MonsterCfg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_MonsterCfg(TB_MonsterCfg other) : this() {
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TB_MonsterCfg Clone() {
      return new TB_MonsterCfg(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pb::FieldCodec<global::TableProto.MonsterCfg> _repeated_data_codec
        = pb::FieldCodec.ForMessage(10, global::TableProto.MonsterCfg.Parser);
    private readonly pbc::RepeatedField<global::TableProto.MonsterCfg> data_ = new pbc::RepeatedField<global::TableProto.MonsterCfg>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::TableProto.MonsterCfg> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TB_MonsterCfg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TB_MonsterCfg other) {
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
    public void MergeFrom(TB_MonsterCfg other) {
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
