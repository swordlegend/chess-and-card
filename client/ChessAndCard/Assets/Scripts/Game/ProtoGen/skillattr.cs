//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: skillattr.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLATTR")]
  public partial class SKILLATTR : global::ProtoBuf.IExtensible
  {
    public SKILLATTR() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _buff_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"buff_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string buff_id
    {
      get { return _buff_id; }
      set { _buff_id = value; }
    }
    private int _damage_formula_type = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"damage_formula_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int damage_formula_type
    {
      get { return _damage_formula_type; }
      set { _damage_formula_type = value; }
    }
    private int _base_factor = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"base_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int base_factor
    {
      get { return _base_factor; }
      set { _base_factor = value; }
    }
    private int _grow_factor = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"grow_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int grow_factor
    {
      get { return _grow_factor; }
      set { _grow_factor = value; }
    }
    private float _base_enhance = (float)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"base_enhance", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float base_enhance
    {
      get { return _base_enhance; }
      set { _base_enhance = value; }
    }
    private float _grow_enhance = (float)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"grow_enhance", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)0)]
    public float grow_enhance
    {
      get { return _grow_enhance; }
      set { _grow_enhance = value; }
    }
    private int _pvp_attr = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"pvp_attr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvp_attr
    {
      get { return _pvp_attr; }
      set { _pvp_attr = value; }
    }
    private string _impact_buff = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"impact_buff", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string impact_buff
    {
      get { return _impact_buff; }
      set { _impact_buff = value; }
    }
    private int _notify_chess = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"notify_chess", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int notify_chess
    {
      get { return _notify_chess; }
      set { _notify_chess = value; }
    }
    private int _chess_buff_id = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"chess_buff_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int chess_buff_id
    {
      get { return _chess_buff_id; }
      set { _chess_buff_id = value; }
    }
    private int _formation = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"formation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int formation
    {
      get { return _formation; }
      set { _formation = value; }
    }
    private int _pvp_chess_openlv = (int)0;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"pvp_chess_openlv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvp_chess_openlv
    {
      get { return _pvp_chess_openlv; }
      set { _pvp_chess_openlv = value; }
    }
    private int _pvp_chess_id = (int)0;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"pvp_chess_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvp_chess_id
    {
      get { return _pvp_chess_id; }
      set { _pvp_chess_id = value; }
    }
    private int _pvp_formation = (int)0;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"pvp_formation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int pvp_formation
    {
      get { return _pvp_formation; }
      set { _pvp_formation = value; }
    }
    private int _in_decrement = (int)0;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"in_decrement", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int in_decrement
    {
      get { return _in_decrement; }
      set { _in_decrement = value; }
    }
    private int _chain_factor = (int)0;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"chain_factor", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int chain_factor
    {
      get { return _chain_factor; }
      set { _chain_factor = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SKILLATTR_ARRAY")]
  public partial class SKILLATTR_ARRAY : global::ProtoBuf.IExtensible
  {
    public SKILLATTR_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.SKILLATTR> _items = new global::System.Collections.Generic.List<deploy.SKILLATTR>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.SKILLATTR> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}