//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: pvp_city.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_CITY")]
  public partial class PVP_CITY : global::ProtoBuf.IExtensible
  {
    public PVP_CITY() {}
    
    private int _city_of_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"city_of_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int city_of_id
    {
      get { return _city_of_id; }
      set { _city_of_id = value; }
    }
    private string _city_name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"city_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string city_name
    {
      get { return _city_name; }
      set { _city_name = value; }
    }
    private int _city_type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"city_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int city_type
    {
      get { return _city_type; }
      set { _city_type = value; }
    }
    private int _protection_time;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"protection_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int protection_time
    {
      get { return _protection_time; }
      set { _protection_time = value; }
    }
    private int _production_type;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"production_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int production_type
    {
      get { return _production_type; }
      set { _production_type = value; }
    }
    private int _city_collectiontime;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"city_collectiontime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int city_collectiontime
    {
      get { return _city_collectiontime; }
      set { _city_collectiontime = value; }
    }
    private int _production_point = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"production_point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int production_point
    {
      get { return _production_point; }
      set { _production_point = value; }
    }
    private int _extra_production = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"extra_production", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int extra_production
    {
      get { return _extra_production; }
      set { _extra_production = value; }
    }
    private int _odds = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"odds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int odds
    {
      get { return _odds; }
      set { _odds = value; }
    }
    private int _defense_bonus = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"defense_bonus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int defense_bonus
    {
      get { return _defense_bonus; }
      set { _defense_bonus = value; }
    }
    private int _res_id = (int)0;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"res_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int res_id
    {
      get { return _res_id; }
      set { _res_id = value; }
    }
    private string _chess_bg = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"chess_bg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chess_bg
    {
      get { return _chess_bg; }
      set { _chess_bg = value; }
    }
    private string _chess_small_bg = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"chess_small_bg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string chess_small_bg
    {
      get { return _chess_small_bg; }
      set { _chess_small_bg = value; }
    }
    private string _speed = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private string _clip_copy = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"clip_copy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clip_copy
    {
      get { return _clip_copy; }
      set { _clip_copy = value; }
    }
    private int _chess_id = (int)0;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"chess_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int chess_id
    {
      get { return _chess_id; }
      set { _chess_id = value; }
    }
    private int _step_limit = (int)0;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"step_limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int step_limit
    {
      get { return _step_limit; }
      set { _step_limit = value; }
    }
    private string _fractional_segment = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"fractional_segment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fractional_segment
    {
      get { return _fractional_segment; }
      set { _fractional_segment = value; }
    }
    private int _city_attribute = (int)0;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"city_attribute", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int city_attribute
    {
      get { return _city_attribute; }
      set { _city_attribute = value; }
    }
    private int _city_attribute_numerical;
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"city_attribute_numerical", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int city_attribute_numerical
    {
      get { return _city_attribute_numerical; }
      set { _city_attribute_numerical = value; }
    }
    private long _city_reward = (long)0;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"city_reward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)0)]
    public long city_reward
    {
      get { return _city_reward; }
      set { _city_reward = value; }
    }
    private int _reward_type = (int)0;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"reward_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int reward_type
    {
      get { return _reward_type; }
      set { _reward_type = value; }
    }
    private int _reward;
    [global::ProtoBuf.ProtoMember(23, IsRequired = true, Name=@"reward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int reward
    {
      get { return _reward; }
      set { _reward = value; }
    }
    private int _reward_max = (int)0;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"reward_max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int reward_max
    {
      get { return _reward_max; }
      set { _reward_max = value; }
    }
    private string _reward_res_id = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"reward_res_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string reward_res_id
    {
      get { return _reward_res_id; }
      set { _reward_res_id = value; }
    }
    private int _country_of_birth = (int)0;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"country_of_birth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int country_of_birth
    {
      get { return _country_of_birth; }
      set { _country_of_birth = value; }
    }
    private string _lose_condition = "";
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"lose_condition", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lose_condition
    {
      get { return _lose_condition; }
      set { _lose_condition = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_CITY_ARRAY")]
  public partial class PVP_CITY_ARRAY : global::ProtoBuf.IExtensible
  {
    public PVP_CITY_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.PVP_CITY> _items = new global::System.Collections.Generic.List<deploy.PVP_CITY>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.PVP_CITY> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}