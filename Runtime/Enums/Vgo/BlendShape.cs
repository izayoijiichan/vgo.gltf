// ----------------------------------------------------------------------
// @Namespace : VgoGltf
// @Class     : 
// ----------------------------------------------------------------------
namespace VgoGltf
{
    /// <summary>The kind of blend shape.</summary>
    public enum VgoBlendShapeKind
    {
        /// <summary></summary>
        None = 0,
        /// <summary></summary>
        Face = 1,
        /// <summary></summary>
        Face_2 = 2,
        /// <summary></summary>
        Kind_3 = 3,
        /// <summary></summary>
        Kind_4 = 4,
        /// <summary></summary>
        Kind_5 = 5,
    }

    /// <summary>The type of the face parts.</summary>
    public enum VgoBlendShapeFacePartsType
    {
        /// <summary></summary>
        None = 0,
        /// <summary>額</summary>
        Forehead = 10,
        /// <summary>眉毛</summary>
        Eyebrow = 11,
        /// <summary>まつ毛</summary>
        Eyelashes = 12,
        /// <summary>瞼</summary>
        Eyelid = 13,
        /// <summary>瞳</summary>
        Pupil = 14,
        /// <summary></summary>
        Ear = 20,
        /// <summary></summary>
        Nose = 30,
        /// <summary></summary>
        Cheek = 40,
        /// <summary></summary>
        Mouth = 50,
        /// <summary></summary>
        Teeth = 51,
        /// <summary></summary>
        Tongue = 52,
        /// <summary></summary>
        Hair = 60,
        /// <summary></summary>
        BackHair = 61,
        /// <summary></summary>
        SideHair = 62,
        /// <summary></summary>
        Frizz = 63,
        /// <summary></summary>
        EarHair = 64,
        /// <summary></summary>
        NoseHair = 65,
        /// <summary></summary>
        Mustache = 66,
        /// <summary></summary>
        Beard = 67,
        /// <summary></summary>
        Mole = 70,
    }

    /// <summary>The type of the blink.</summary>
    public enum VgoBlendShapeBlinkType
    {
        /// <summary></summary>
        None,
        /// <summary></summary>
        Both,
        /// <summary></summary>
        Left,
        /// <summary></summary>
        Right,
    }

    /// <summary>The Viseme.</summary>
    public enum VgoBlendShapeViseme
    {
        /// <summary></summary>
        Silence = 0,
        /// <summary></summary>
        /// <remarks>p、b、m</remarks>
        PP = 1,
        /// <summary></summary>
        /// <remarks>f、v</remarks>
        FF = 2,
        /// <summary></summary>
        /// <remarks>th</remarks>
        TH = 3,
        /// <summary></summary>
        /// <remarks>t、d</remarks>
        DD = 4,
        /// <summary></summary>
        /// <remarks>k、g</remarks>
        kk = 5,
        /// <summary></summary>
        /// <remarks>tS、dZ、S</remarks>
        CH = 6,
        /// <summary></summary>
        /// <remarks>s、z</remarks>
        SS = 7,
        /// <summary></summary>
        /// <remarks>n、l</remarks>
        nn = 8,
        /// <summary></summary>
        /// <remarks>r</remarks>
        RR = 9,
        /// <summary></summary>
        /// <remarks>A:</remarks>
        A = 10,
        /// <summary></summary>
        /// <remarks>e</remarks>
        E = 11,
        /// <summary></summary>
        /// <remarks>ih</remarks>
        I = 12,
        /// <summary></summary>
        /// <remarks>oh</remarks>
        O = 13,
        /// <summary></summary>
        /// <remarks>ou</remarks>
        U = 14,
    }

    /// <summary></summary>
    public enum VgoBlendShapePresetType
    {
        /// <summary></summary>
        Custom = 0,
        /// <summary></summary>
        Neutral,
        /// <summary></summary>
        Joy,
        /// <summary></summary>
        Angry,
        /// <summary></summary>
        Sorrow,
        /// <summary></summary>
        Fun,
        /// <summary></summary>
        Confuse,
        /// <summary></summary>
        Nervous,
        /// <summary></summary>
        Sleepy,
        /// <summary></summary>
        Surprise,
        /// <summary></summary>
        WinkL,
        /// <summary></summary>
        WinkR,
        /// <summary></summary>
        Preset_12,
        /// <summary></summary>
        Preset_13,
        /// <summary></summary>
        Preset_14,
        /// <summary></summary>
        Preset_15,
    }
}
