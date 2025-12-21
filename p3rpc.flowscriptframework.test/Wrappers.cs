// ReSharper disable InconsistentNaming
using p3rpc.flowscriptframework.Interfaces;
namespace p3rpc.flowscriptframework.test;
public class Wrappers(IFlowFramework flowLib)
{
	private IFlowFramework FlowLib { get; } = flowLib;

	public void SYNC() =>
		FlowLib.InvokeVoid("SYNC", []);
	public void WAIT(int param0) =>
		FlowLib.InvokeVoid("WAIT", [new IntParam(param0)]);
	public void PUT(int param0) =>
		FlowLib.InvokeVoid("PUT", [new IntParam(param0)]);
	public void PUTS(string param0) =>
		FlowLib.InvokeVoid("PUTS", [new StringParam(param0)]);
	public void PUTF(float param0) =>
		FlowLib.InvokeVoid("PUTF", [new FloatParam(param0)]);
	public void MSG(int param0, int param1) =>
		FlowLib.InvokeVoid("MSG", [new IntParam(param0), new IntParam(param1)]);
	public int MSG_SEL(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("MSG_SEL", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FADE_IN(int param0, int param1) =>
		FlowLib.InvokeVoid("FADE_IN", [new IntParam(param0), new IntParam(param1)]);
	public void FADE_OUT(int param0, int param1) =>
		FlowLib.InvokeVoid("FADE_OUT", [new IntParam(param0), new IntParam(param1)]);
	public void FADEEND_CHECK() =>
		FlowLib.InvokeVoid("FADEEND_CHECK", []);
	public void FADE_SYNC() =>
		FlowLib.InvokeVoid("FADE_SYNC", []);
	public void SET_EXIT_VALUE(int param0) =>
		FlowLib.InvokeVoid("SET_EXIT_VALUE", [new IntParam(param0)]);
	public int BIT_ON(int param0) =>
		FlowLib.InvokeInt("BIT_ON", [new IntParam(param0)]);
	public int BIT_OFF(int param0) =>
		FlowLib.InvokeInt("BIT_OFF", [new IntParam(param0)]);
	public int BIT_CHK(int param0) =>
		FlowLib.InvokeInt("BIT_CHK", [new IntParam(param0)]);
	public int SEL(int param0) =>
		FlowLib.InvokeInt("SEL", [new IntParam(param0)]);
	public void MESSAGE_REF(int param0, int param1) =>
		FlowLib.InvokeVoid("MESSAGE_REF", [new IntParam(param0), new IntParam(param1)]);
	public void CALL_TUTORIAL(int param0, int param1) =>
		FlowLib.InvokeVoid("CALL_TUTORIAL", [new IntParam(param0), new IntParam(param1)]);
	public void MSG_WND_DSP() =>
		FlowLib.InvokeVoid("MSG_WND_DSP", []);
	public void MSG_WND_CLS() =>
		FlowLib.InvokeVoid("MSG_WND_CLS", []);
	public void CALL_CALENDAR() =>
		FlowLib.InvokeVoid("CALL_CALENDAR", []);
	public void CALL_NEXTTIME() =>
		FlowLib.InvokeVoid("CALL_NEXTTIME", []);
	public int GET_TIME() =>
		FlowLib.InvokeInt("GET_TIME", []);
	public int GET_DAYOFWEEK() =>
		FlowLib.InvokeInt("GET_DAYOFWEEK", []);
	public int CHK_DAY(int param0, int param1) =>
		FlowLib.InvokeInt("CHK_DAY", [new IntParam(param0), new IntParam(param1)]);
	public int CHK_DAYS_STARTEND(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeInt("CHK_DAYS_STARTEND", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public int CHK_TIME(int param0) =>
		FlowLib.InvokeInt("CHK_TIME", [new IntParam(param0)]);
	public int CHK_DAYOFWEEK(int param0) =>
		FlowLib.InvokeInt("CHK_DAYOFWEEK", [new IntParam(param0)]);
	public void CALL_LEVEL(string param0, string param1, int param2, int param3) =>
		FlowLib.InvokeVoid("CALL_LEVEL", [new StringParam(param0), new StringParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void SET_MSG_VAR(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("SET_MSG_VAR", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int GET_COUNT(int param0) =>
		FlowLib.InvokeInt("GET_COUNT", [new IntParam(param0)]);
	public void SET_COUNT(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_COUNT", [new IntParam(param0), new IntParam(param1)]);
	public void DBG_PUT(int param0) =>
		FlowLib.InvokeVoid("DBG_PUT", [new IntParam(param0)]);
	public void DBG_PUTS(string param0) =>
		FlowLib.InvokeVoid("DBG_PUTS", [new StringParam(param0)]);
	public int RND(int param0) =>
		FlowLib.InvokeInt("RND", [new IntParam(param0)]);
	public int GET_AND(int param0, int param1) =>
		FlowLib.InvokeInt("GET_AND", [new IntParam(param0), new IntParam(param1)]);
	public int GET_OR(int param0, int param1) =>
		FlowLib.InvokeInt("GET_OR", [new IntParam(param0), new IntParam(param1)]);
	public int GET_XOR(int param0, int param1) =>
		FlowLib.InvokeInt("GET_XOR", [new IntParam(param0), new IntParam(param1)]);
	public int GET_L_SHIFT(int param0, int param1) =>
		FlowLib.InvokeInt("GET_L_SHIFT", [new IntParam(param0), new IntParam(param1)]);
	public int GET_R_SHIFT(int param0, int param1) =>
		FlowLib.InvokeInt("GET_R_SHIFT", [new IntParam(param0), new IntParam(param1)]);
	public int REM(int param0, int param1) =>
		FlowLib.InvokeInt("REM", [new IntParam(param0), new IntParam(param1)]);
	public int SIN(float param0) =>
		FlowLib.InvokeInt("SIN", [new FloatParam(param0)]);
	public int COS(float param0) =>
		FlowLib.InvokeInt("COS", [new FloatParam(param0)]);
	public int TAN(float param0) =>
		FlowLib.InvokeInt("TAN", [new FloatParam(param0)]);
	public int ASIN(float param0) =>
		FlowLib.InvokeInt("ASIN", [new FloatParam(param0)]);
	public int ACOS(float param0) =>
		FlowLib.InvokeInt("ACOS", [new FloatParam(param0)]);
	public int ATAN(float param0) =>
		FlowLib.InvokeInt("ATAN", [new FloatParam(param0)]);
	public int ATAN2(float param0) =>
		FlowLib.InvokeInt("ATAN2", [new FloatParam(param0)]);
	public int SQRT(float param0) =>
		FlowLib.InvokeInt("SQRT", [new FloatParam(param0)]);
	public int GET_MAX(float param0, float param1) =>
		FlowLib.InvokeInt("GET_MAX", [new FloatParam(param0), new FloatParam(param1)]);
	public int GET_MIN(float param0, float param1) =>
		FlowLib.InvokeInt("GET_MIN", [new FloatParam(param0), new FloatParam(param1)]);
	public void SEL_DEFKEY(int param0, int param1) =>
		FlowLib.InvokeVoid("SEL_DEFKEY", [new IntParam(param0), new IntParam(param1)]);
	public void SET_NEXT_DAY(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("SET_NEXT_DAY", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void SEL_MASK(int param0, int param1) =>
		FlowLib.InvokeVoid("SEL_MASK", [new IntParam(param0), new IntParam(param1)]);
	public void SEL_INDEX_MASK(int param0) =>
		FlowLib.InvokeVoid("SEL_INDEX_MASK", [new IntParam(param0)]);
	public int SEL_GENERIC_EX(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeInt("SEL_GENERIC_EX", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public int GET_MONEY() =>
		FlowLib.InvokeInt("GET_MONEY", []);
	public void BGM(int param0) =>
		FlowLib.InvokeVoid("BGM", [new IntParam(param0)]);
	public void BGM_STOP(int param0) =>
		FlowLib.InvokeVoid("BGM_STOP", [new IntParam(param0)]);
	public void BGM_FADEIN(int param0) =>
		FlowLib.InvokeVoid("BGM_FADEIN", [new IntParam(param0)]);
	public void PARTY_IN(int param0) =>
		FlowLib.InvokeVoid("PARTY_IN", [new IntParam(param0)]);
	public void PARTY_OUT(int param0) =>
		FlowLib.InvokeVoid("PARTY_OUT", [new IntParam(param0)]);
	public int GET_PARTY(int param0) =>
		FlowLib.InvokeInt("GET_PARTY", [new IntParam(param0)]);
	public int CHK_PARTY_FULL() =>
		FlowLib.InvokeInt("CHK_PARTY_FULL", []);
	public int IS_PARTY_EXISTS(int param0) =>
		FlowLib.InvokeInt("IS_PARTY_EXISTS", [new IntParam(param0)]);
	public int GET_MONTH() =>
		FlowLib.InvokeInt("GET_MONTH", []);
	public int GET_DAY() =>
		FlowLib.InvokeInt("GET_DAY", []);
	public int GET_TOTAL_DAY() =>
		FlowLib.InvokeInt("GET_TOTAL_DAY", []);
	public int GET_MONTH_TOTAL_DAY(int param0) =>
		FlowLib.InvokeInt("GET_MONTH_TOTAL_DAY", [new IntParam(param0)]);
	public int GET_DAY_TOTAL_DAY(int param0) =>
		FlowLib.InvokeInt("GET_DAY_TOTAL_DAY", [new IntParam(param0)]);
	public void MOVIE_PLAY(int param0) =>
		FlowLib.InvokeVoid("MOVIE_PLAY", [new IntParam(param0)]);
	public int MOVIE_SYNC() =>
		FlowLib.InvokeInt("MOVIE_SYNC", []);
	public void SCHE_CALL_MORNING_EVENT(int param0) =>
		FlowLib.InvokeVoid("SCHE_CALL_MORNING_EVENT", [new IntParam(param0)]);
	public void SCHE_CALL_TEACHING_EVENT(int param0) =>
		FlowLib.InvokeVoid("SCHE_CALL_TEACHING_EVENT", [new IntParam(param0)]);
	public void RECOVERY_ALL() =>
		FlowLib.InvokeVoid("RECOVERY_ALL", []);
	public void RANDOM_BOX_CLEAR() =>
		FlowLib.InvokeVoid("RANDOM_BOX_CLEAR", []);
	public void RANDOM_BOX_SET_NUM(int param0) =>
		FlowLib.InvokeVoid("RANDOM_BOX_SET_NUM", [new IntParam(param0)]);
	public int RANDOM_BOX_GET_NUM() =>
		FlowLib.InvokeInt("RANDOM_BOX_GET_NUM", []);
	public int RANDOM_BOX_CHECK_DATANUM() =>
		FlowLib.InvokeInt("RANDOM_BOX_CHECK_DATANUM", []);
	public int GET_EQUIP(int param0, int param1) =>
		FlowLib.InvokeInt("GET_EQUIP", [new IntParam(param0), new IntParam(param1)]);
	public int SET_EQUIP(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("SET_EQUIP", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void SET_PERSONA_LV(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("SET_PERSONA_LV", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void CLEAR_PERSONA_STOCK() =>
		FlowLib.InvokeVoid("CLEAR_PERSONA_STOCK", []);
	public void ADD_PERSONA_STOCK(int param0) =>
		FlowLib.InvokeVoid("ADD_PERSONA_STOCK", [new IntParam(param0)]);
	public void SET_EQUIP_PERSONA(int param0) =>
		FlowLib.InvokeVoid("SET_EQUIP_PERSONA", [new IntParam(param0)]);
	public void ADD_PERSONA_SKILL(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("ADD_PERSONA_SKILL", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void REMOVE_PERSONA_SKILL(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("REMOVE_PERSONA_SKILL", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void PERSONA_EVOLUTION(int param0) =>
		FlowLib.InvokeVoid("PERSONA_EVOLUTION", [new IntParam(param0)]);
	public int CHK_PERSONA_EVOLUTION(int param0) =>
		FlowLib.InvokeInt("CHK_PERSONA_EVOLUTION", [new IntParam(param0)]);
	public int CHECK_FULLHPSP_ALL() =>
		FlowLib.InvokeInt("CHECK_FULLHPSP_ALL", []);
	public void FADE_COLOR(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FADE_COLOR", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int GET_HP(int param0) =>
		FlowLib.InvokeInt("GET_HP", [new IntParam(param0)]);
	public int GET_MAXHP(int param0) =>
		FlowLib.InvokeInt("GET_MAXHP", [new IntParam(param0)]);
	public int SET_HP(int param0, int param1) =>
		FlowLib.InvokeInt("SET_HP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_SP(int param0) =>
		FlowLib.InvokeInt("GET_SP", [new IntParam(param0)]);
	public int GET_MAXSP(int param0) =>
		FlowLib.InvokeInt("GET_MAXSP", [new IntParam(param0)]);
	public int SET_SP(int param0, int param1) =>
		FlowLib.InvokeInt("SET_SP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_PC_LEVEL(int param0) =>
		FlowLib.InvokeInt("GET_PC_LEVEL", [new IntParam(param0)]);
	public void SEL_GENERIC_MASK(int param0, int param1) =>
		FlowLib.InvokeVoid("SEL_GENERIC_MASK", [new IntParam(param0), new IntParam(param1)]);
	public void SEL_GENERIC_INDEX_MASK(int param0) =>
		FlowLib.InvokeVoid("SEL_GENERIC_INDEX_MASK", [new IntParam(param0)]);
	public int DBG_SCRIPT_START(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("DBG_SCRIPT_START", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int ADD_PC_MONEY(int param0) =>
		FlowLib.InvokeInt("ADD_PC_MONEY", [new IntParam(param0)]);
	public void CALL_TITLE() =>
		FlowLib.InvokeVoid("CALL_TITLE", []);
	public int GET_PLAYER_LV(int param0, int param1) =>
		FlowLib.InvokeInt("GET_PLAYER_LV", [new IntParam(param0), new IntParam(param1)]);
	public int SEL_GENERIC_ITEM_EX(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeInt("SEL_GENERIC_ITEM_EX", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public int SEL_GENERIC_CAN_OPEN(int param0) =>
		FlowLib.InvokeInt("SEL_GENERIC_CAN_OPEN", [new IntParam(param0)]);
	public int SEL_GENERIC_ITEM_CAN_OPEN(int param0) =>
		FlowLib.InvokeInt("SEL_GENERIC_ITEM_CAN_OPEN", [new IntParam(param0)]);
	public int SCHE_GET_PICTID_TEACH_QUESTION() =>
		FlowLib.InvokeInt("SCHE_GET_PICTID_TEACH_QUESTION", []);
	public int SCHE_GET_PICTID_TEACH_ANSWER() =>
		FlowLib.InvokeInt("SCHE_GET_PICTID_TEACH_ANSWER", []);
	public int ADD_SPECIAL_SKILL(int param0, int param1) =>
		FlowLib.InvokeInt("ADD_SPECIAL_SKILL", [new IntParam(param0), new IntParam(param1)]);
	public int REMOVE_SPECIAL_SKILL(int param0, int param1) =>
		FlowLib.InvokeInt("REMOVE_SPECIAL_SKILL", [new IntParam(param0), new IntParam(param1)]);
	public int CLEAR_SPECIAL_SKILL(int param0) =>
		FlowLib.InvokeInt("CLEAR_SPECIAL_SKILL", [new IntParam(param0)]);
	public int SET_TP(int param0, int param1) =>
		FlowLib.InvokeInt("SET_TP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_TP(int param0) =>
		FlowLib.InvokeInt("GET_TP", [new IntParam(param0)]);
	public int GET_MAXTP(int param0) =>
		FlowLib.InvokeInt("GET_MAXTP", [new IntParam(param0)]);
	public int GET_EQUIP_PERSONA_PARAM(int param0, int param1) =>
		FlowLib.InvokeInt("GET_EQUIP_PERSONA_PARAM", [new IntParam(param0), new IntParam(param1)]);
	public int ADD_EQUIP_PERSONA_PARAMS(int param0, int param1, int param2, int param3, int param4, int param5) =>
		FlowLib.InvokeInt("ADD_EQUIP_PERSONA_PARAMS", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5)]);
	public int ADD_EQUIP_PERSONA_PARAMS_INC(int param0, int param1, int param2, int param3, int param4, int param5) =>
		FlowLib.InvokeInt("ADD_EQUIP_PERSONA_PARAMS_INC", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5)]);
	public void COMSE_PLAY(int param0) =>
		FlowLib.InvokeVoid("COMSE_PLAY", [new IntParam(param0)]);
	public void COMSE_STOP(int param0) =>
		FlowLib.InvokeVoid("COMSE_STOP", [new IntParam(param0)]);
	public void SET_HUMAN_LV(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_HUMAN_LV", [new IntParam(param0), new IntParam(param1)]);
	public void ADD_MAXHP_UP(int param0, int param1) =>
		FlowLib.InvokeVoid("ADD_MAXHP_UP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_MAXHP_UP(int param0) =>
		FlowLib.InvokeInt("GET_MAXHP_UP", [new IntParam(param0)]);
	public void ADD_MAXSP_UP(int param0, int param1) =>
		FlowLib.InvokeVoid("ADD_MAXSP_UP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_MAXSP_UP(int param0) =>
		FlowLib.InvokeInt("GET_MAXSP_UP", [new IntParam(param0)]);
	public int GET_SKILL_COST(int param0, int param1) =>
		FlowLib.InvokeInt("GET_SKILL_COST", [new IntParam(param0), new IntParam(param1)]);
	public void DEBUG_SET_DAY(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("DEBUG_SET_DAY", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void MDL_ICON(int param0, int param1) =>
		FlowLib.InvokeVoid("MDL_ICON", [new IntParam(param0), new IntParam(param1)]);
	public void MDL_ICON_END(int param0, int param1) =>
		FlowLib.InvokeVoid("MDL_ICON_END", [new IntParam(param0), new IntParam(param1)]);
	public void MDL_ICON_EX(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("MDL_ICON_EX", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void MDL_ICON_SET_SCALE(int param0, int param1) =>
		FlowLib.InvokeVoid("MDL_ICON_SET_SCALE", [new IntParam(param0), new IntParam(param1)]);
	public void CALL_DICTIONARY(int param0) =>
		FlowLib.InvokeVoid("CALL_DICTIONARY", [new IntParam(param0)]);
	public void SYNC_ACTIVITY() =>
		FlowLib.InvokeVoid("SYNC_ACTIVITY", []);
	public int CHK_CHUNK_INSTALL() =>
		FlowLib.InvokeInt("CHK_CHUNK_INSTALL", []);
	public int MSG_WINDOW_LAST() =>
		FlowLib.InvokeInt("MSG_WINDOW_LAST", []);
	public int CHK_CHUNK_INSTALL_DIALOG() =>
		FlowLib.InvokeInt("CHK_CHUNK_INSTALL_DIALOG", []);
	public int GET_ITEM_TYPE(int param0) =>
		FlowLib.InvokeInt("GET_ITEM_TYPE", [new IntParam(param0)]);
	public int GET_EQUIP_ENABLE_PLAYER(int param0) =>
		FlowLib.InvokeInt("GET_EQUIP_ENABLE_PLAYER", [new IntParam(param0)]);
	public int GET_ITEM_ATTACK(int param0) =>
		FlowLib.InvokeInt("GET_ITEM_ATTACK", [new IntParam(param0)]);
	public int CHANGE_EQUIP_ITEM(int param0, int param1) =>
		FlowLib.InvokeInt("CHANGE_EQUIP_ITEM", [new IntParam(param0), new IntParam(param1)]);
	public int SEL_GENERIC_SHOP(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeInt("SEL_GENERIC_SHOP", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public int GET_ITEM_DEFENCE(int param0) =>
		FlowLib.InvokeInt("GET_ITEM_DEFENCE", [new IntParam(param0)]);
	public int GET_ITEM_EVASION(int param0) =>
		FlowLib.InvokeInt("GET_ITEM_EVASION", [new IntParam(param0)]);
	public int GET_PERSONA_STOCK_NUM() =>
		FlowLib.InvokeInt("GET_PERSONA_STOCK_NUM", []);
	public int GET_PERSONA_STOCK_MAX() =>
		FlowLib.InvokeInt("GET_PERSONA_STOCK_MAX", []);
	public int GET_STOCK_PERSONA_MAX_LEVEL() =>
		FlowLib.InvokeInt("GET_STOCK_PERSONA_MAX_LEVEL", []);
	public int CHK_ARBEIT_ENABLE(int param0) =>
		FlowLib.InvokeInt("CHK_ARBEIT_ENABLE", [new IntParam(param0)]);
	public void MOVIE_LOAD(int param0) =>
		FlowLib.InvokeVoid("MOVIE_LOAD", [new IntParam(param0)]);
	public void MOVIE_PLAY_WITHOUT_LOAD(int param0) =>
		FlowLib.InvokeVoid("MOVIE_PLAY_WITHOUT_LOAD", [new IntParam(param0)]);
	public void MOVIE_SYNC_AND_FADE_OUT_WITH_COLOR(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeVoid("MOVIE_SYNC_AND_FADE_OUT_WITH_COLOR", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public void REQUEST_DAY_CHANGE_EFFECT(int param0, int param1) =>
		FlowLib.InvokeVoid("REQUEST_DAY_CHANGE_EFFECT", [new IntParam(param0), new IntParam(param1)]);
	public void SEL_DEFKEY_CLEAR() =>
		FlowLib.InvokeVoid("SEL_DEFKEY_CLEAR", []);
	public void MOVIE_ENABLE_BGM_PAUSE(int param0) =>
		FlowLib.InvokeVoid("MOVIE_ENABLE_BGM_PAUSE", [new IntParam(param0)]);
	public void MOVIE_ENABLE_PLAY_BATTLEWIPE_SE(int param0) =>
		FlowLib.InvokeVoid("MOVIE_ENABLE_PLAY_BATTLEWIPE_SE", [new IntParam(param0)]);
	public void ASTREA_DUMMY1() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY1", []);
	public void ASTREA_DUMMY2() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY2", []);
	public void ASTREA_DUMMY3() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY3", []);
	public void ASTREA_DUMMY4() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY4", []);
	public void ASTREA_DUMMY5() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY5", []);
	public void ASTREA_DUMMY6() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY6", []);
	public void ASTREA_DUMMY7() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY7", []);
	public void ASTREA_DUMMY8() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY8", []);
	public void ASTREA_DUMMY9() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY9", []);
	public void ASTREA_DUMMY10() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY10", []);
	public void ASTREA_DUMMY11() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY11", []);
	public void ASTREA_DUMMY12() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY12", []);
	public void ASTREA_DUMMY13() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY13", []);
	public void ASTREA_DUMMY14() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY14", []);
	public void ASTREA_DUMMY15() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY15", []);
	public void ASTREA_DUMMY16() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY16", []);
	public void ASTREA_DUMMY17() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY17", []);
	public void ASTREA_DUMMY18() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY18", []);
	public void ASTREA_DUMMY19() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY19", []);
	public void ASTREA_DUMMY20() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY20", []);
	public void ASTREA_DUMMY21() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY21", []);
	public void ASTREA_DUMMY22() =>
		FlowLib.InvokeVoid("ASTREA_DUMMY22", []);
	public void DBG_SET_PLAYING_ASTREA(int param0) =>
		FlowLib.InvokeVoid("DBG_SET_PLAYING_ASTREA", [new IntParam(param0)]);
	public void DBG_RESIDENT_RELOAD_REQ() =>
		FlowLib.InvokeVoid("DBG_RESIDENT_RELOAD_REQ", []);
	public void DBG_RESIDENT_RELOAD_SYNC() =>
		FlowLib.InvokeVoid("DBG_RESIDENT_RELOAD_SYNC", []);
	public void CALL_ASTREA_PROGRESS() =>
		FlowLib.InvokeVoid("CALL_ASTREA_PROGRESS", []);
	public int GET_PROGRESS_ASTREA() =>
		FlowLib.InvokeInt("GET_PROGRESS_ASTREA", []);
	public int CHK_PROGRESS_ASTREA(int param0) =>
		FlowLib.InvokeInt("CHK_PROGRESS_ASTREA", [new IntParam(param0)]);
	public int CHK_PROGRESS_STARTEND_ASTREA(int param0, int param1) =>
		FlowLib.InvokeInt("CHK_PROGRESS_STARTEND_ASTREA", [new IntParam(param0), new IntParam(param1)]);
	public void DEBUG_SET_PROGRESS_ASTREA(int param0) =>
		FlowLib.InvokeVoid("DEBUG_SET_PROGRESS_ASTREA", [new IntParam(param0)]);
	public void START_NEXTPROGRESS_ASTREA() =>
		FlowLib.InvokeVoid("START_NEXTPROGRESS_ASTREA", []);
	public int CHK_PROGRESS_UNDER_ASTREA(int param0) =>
		FlowLib.InvokeInt("CHK_PROGRESS_UNDER_ASTREA", [new IntParam(param0)]);
	public int CHK_PROGRESS_OVER_ASTREA(int param0) =>
		FlowLib.InvokeInt("CHK_PROGRESS_OVER_ASTREA", [new IntParam(param0)]);
	public void REQUEST_DAY_CHANGE_EFFECT_START_END(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeVoid("REQUEST_DAY_CHANGE_EFFECT_START_END", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void REQUEST_TIME_CHANGE_EFFECT(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeVoid("REQUEST_TIME_CHANGE_EFFECT", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void START_PROGRESS_ASTREA(int param0) =>
		FlowLib.InvokeVoid("START_PROGRESS_ASTREA", [new IntParam(param0)]);
	public void SET_INITIAL_PERSONABOOK_ASTREA() =>
		FlowLib.InvokeVoid("SET_INITIAL_PERSONABOOK_ASTREA", []);
	public void INITIALIZE_TUTORIAL_AND_DICTIONALY_FLAG_ASTREA() =>
		FlowLib.InvokeVoid("INITIALIZE_TUTORIAL_AND_DICTIONALY_FLAG_ASTREA", []);
	public int CALC_CURRENT_DESIGN_TYPE_ID_ASTREA() =>
		FlowLib.InvokeInt("CALC_CURRENT_DESIGN_TYPE_ID_ASTREA", []);
	public int CALC_WEIGHTED_RANDOM_PLAYERID_ASTREA(int param0, int param1, int param2, int param3, int param4, int param5, int param6, int param7) =>
		FlowLib.InvokeInt("CALC_WEIGHTED_RANDOM_PLAYERID_ASTREA", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5), new IntParam(param6), new IntParam(param7)]);
	public void END_CLEAR_SAVE_DATA() =>
		FlowLib.InvokeVoid("END_CLEAR_SAVE_DATA", []);
	public void DUNGEON_HIDDEN_DIRECT_SYMBOL(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_HIDDEN_DIRECT_SYMBOL", [new IntParam(param0)]);
	public void DUNGEON_VISIBLE_DIRECT_SYMBOL(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_VISIBLE_DIRECT_SYMBOL", [new IntParam(param0)]);
	public void UPDATE_DIFFICULTY_TEMP_CLEAR_SAVE_DATA() =>
		FlowLib.InvokeVoid("UPDATE_DIFFICULTY_TEMP_CLEAR_SAVE_DATA", []);
	public void AI_SEQUENCE_BEGIN(int param0) =>
		FlowLib.InvokeVoid("AI_SEQUENCE_BEGIN", [new IntParam(param0)]);
	public void AI_ACT_ATTACK() =>
		FlowLib.InvokeVoid("AI_ACT_ATTACK", []);
	public void AI_ACT_SKILL(int param0) =>
		FlowLib.InvokeVoid("AI_ACT_SKILL", [new IntParam(param0)]);
	public void AI_ACT_GUARDORDER() =>
		FlowLib.InvokeVoid("AI_ACT_GUARDORDER", []);
	public void AI_TAR_HERO() =>
		FlowLib.InvokeVoid("AI_TAR_HERO", []);
	public void AI_TAR_MINE() =>
		FlowLib.InvokeVoid("AI_TAR_MINE", []);
	public void AI_TAR_RND() =>
		FlowLib.InvokeVoid("AI_TAR_RND", []);
	public void AI_TAR_MYAI() =>
		FlowLib.InvokeVoid("AI_TAR_MYAI", []);
	public void AI_TAR_HPMIN() =>
		FlowLib.InvokeVoid("AI_TAR_HPMIN", []);
	public void AI_TAR_HPMAX() =>
		FlowLib.InvokeVoid("AI_TAR_HPMAX", []);
	public void AI_TAR_BAD(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_BAD", [new IntParam(param0)]);
	public void AI_TAR_NOTBAD(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTBAD", [new IntParam(param0)]);
	public void AI_TAR_HOJO(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_HOJO", [new IntParam(param0)]);
	public void AI_TAR_NOTHOJO(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTHOJO", [new IntParam(param0)]);
	public void AI_TAR_DOWN() =>
		FlowLib.InvokeVoid("AI_TAR_DOWN", []);
	public void AI_TAR_STAND() =>
		FlowLib.InvokeVoid("AI_TAR_STAND", []);
	public void AI_TAR_ID(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_ID", [new IntParam(param0)]);
	public void AI_TAR_NOTID(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTID", [new IntParam(param0)]);
	public void AI_TAR_APPOINT() =>
		FlowLib.InvokeVoid("AI_TAR_APPOINT", []);
	public void AI_TAR_MPMAX() =>
		FlowLib.InvokeVoid("AI_TAR_MPMAX", []);
	public void AI_TAR_SPMAX() =>
		FlowLib.InvokeVoid("AI_TAR_SPMAX", []);
	public int AI_CHK_MORE() =>
		FlowLib.InvokeInt("AI_CHK_MORE", []);
	public int AI_CHK_FRID(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRID", [new IntParam(param0)]);
	public int AI_CHK_ENID(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENID", [new IntParam(param0)]);
	public int AI_CHK_TURN(int param0) =>
		FlowLib.InvokeInt("AI_CHK_TURN", [new IntParam(param0)]);
	public int AI_CHK_TURN_O(int param0) =>
		FlowLib.InvokeInt("AI_CHK_TURN_O", [new IntParam(param0)]);
	public int AI_CHK_BOSS() =>
		FlowLib.InvokeInt("AI_CHK_BOSS", []);
	public int AI_CHK_ESCAPE() =>
		FlowLib.InvokeInt("AI_CHK_ESCAPE", []);
	public int AI_CHK_ANALYZE(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ANALYZE", [new IntParam(param0)]);
	public int AI_CHK_DOWN(int param0) =>
		FlowLib.InvokeInt("AI_CHK_DOWN", [new IntParam(param0)]);
	public int AI_CHK_SLIP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_SLIP", [new IntParam(param0)]);
	public int AI_CHK_MYWEAK(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYWEAK", [new IntParam(param0)]);
	public int AI_CHK_FRWEAK(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRWEAK", [new IntParam(param0)]);
	public int AI_CHK_ENWEAK(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENWEAK", [new IntParam(param0)]);
	public int AI_CHK_MYMUKOU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYMUKOU", [new IntParam(param0)]);
	public int AI_CHK_FRMUKOU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRMUKOU", [new IntParam(param0)]);
	public int AI_CHK_ENMUKOU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENMUKOU", [new IntParam(param0)]);
	public int AI_CHK_ENTAISEI(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENTAISEI", [new IntParam(param0)]);
	public int AI_CHK_MYHANSYA(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYHANSYA", [new IntParam(param0)]);
	public int AI_CHK_FRHANSYA(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRHANSYA", [new IntParam(param0)]);
	public int AI_CHK_ENHANSYA(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENHANSYA", [new IntParam(param0)]);
	public int AI_CHK_MYKYUSYU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYKYUSYU", [new IntParam(param0)]);
	public int AI_CHK_FRKYUSYU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRKYUSYU", [new IntParam(param0)]);
	public int AI_CHK_ENKYUSYU(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENKYUSYU", [new IntParam(param0)]);
	public int AI_CHK_PREV_ATK() =>
		FlowLib.InvokeInt("AI_CHK_PREV_ATK", []);
	public int AI_CHK_PREV_WAIT() =>
		FlowLib.InvokeInt("AI_CHK_PREV_WAIT", []);
	public int AI_CHK_MYUSESKIL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYUSESKIL", [new IntParam(param0)]);
	public int AI_CHK_FRUSESKIL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRUSESKIL", [new IntParam(param0)]);
	public int AI_CHK_ENUSESKIL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENUSESKIL", [new IntParam(param0)]);
	public int AI_CHK_MYHP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYHP", [new IntParam(param0)]);
	public int AI_CHK_MYMP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYMP", [new IntParam(param0)]);
	public int AI_CHK_MYSP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYSP", [new IntParam(param0)]);
	public int AI_CHK_FRHP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRHP", [new IntParam(param0)]);
	public int AI_CHK_ENHP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENHP", [new IntParam(param0)]);
	public int AI_CHK_ENHP_O(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENHP_O", [new IntParam(param0)]);
	public int AI_CHK_UNIHP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_UNIHP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRCNT(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRCNT", [new IntParam(param0)]);
	public int AI_CHK_ENCNT(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENCNT", [new IntParam(param0)]);
	public int AI_CHK_MYBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYBAD", [new IntParam(param0)]);
	public int AI_CHK_FRBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRBAD", [new IntParam(param0)]);
	public int AI_CHK_ENBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENBAD", [new IntParam(param0)]);
	public int AI_CHK_UNIBAD(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_UNIBAD", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_NOTMYBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTMYBAD", [new IntParam(param0)]);
	public int AI_CHK_NOTFRBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTFRBAD", [new IntParam(param0)]);
	public int AI_CHK_NOTENBAD(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTENBAD", [new IntParam(param0)]);
	public int AI_CHK_MYHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYHOJO", [new IntParam(param0)]);
	public int AI_CHK_FRHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRHOJO", [new IntParam(param0)]);
	public int AI_CHK_ENHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENHOJO", [new IntParam(param0)]);
	public int AI_CHK_NOTMYHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTMYHOJO", [new IntParam(param0)]);
	public int AI_CHK_NOTFRHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTFRHOJO", [new IntParam(param0)]);
	public int AI_CHK_NOTENHOJO(int param0) =>
		FlowLib.InvokeInt("AI_CHK_NOTENHOJO", [new IntParam(param0)]);
	public int AI_CHK_FRIDHP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDHP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDBAD(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDBAD", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDBAD_ALL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDBAD_ALL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDHOJO(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDHOJO", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDWEAK(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDWEAK", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDMUKOU(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDMUKOU", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDHANSYA(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDHANSYA", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDKYUSYU(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDKYUSYU", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDUSESKIL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDUSESKIL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_GET_FIRST_ACTION() =>
		FlowLib.InvokeInt("AI_GET_FIRST_ACTION", []);
	public int AI_GET_ENBADOFF(int param0) =>
		FlowLib.InvokeInt("AI_GET_ENBADOFF", [new IntParam(param0)]);
	public int AI_GET_MYATTRATTACK() =>
		FlowLib.InvokeInt("AI_GET_MYATTRATTACK", []);
	public int AI_GET_ENID_MAXSERIAL(int param0) =>
		FlowLib.InvokeInt("AI_GET_ENID_MAXSERIAL", [new IntParam(param0)]);
	public int AI_GET_P_NUM() =>
		FlowLib.InvokeInt("AI_GET_P_NUM", []);
	public int AI_GET_E_NUM() =>
		FlowLib.InvokeInt("AI_GET_E_NUM", []);
	public int AI_GET_FRHP(int param0) =>
		FlowLib.InvokeInt("AI_GET_FRHP", [new IntParam(param0)]);
	public int AI_GET_UNIRANDOM() =>
		FlowLib.InvokeInt("AI_GET_UNIRANDOM", []);
	public int AI_GET_UNIATAB(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIATAB", [new IntParam(param0)]);
	public int AI_GET_UNIATAB_ST(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIATAB_ST", [new IntParam(param0)]);
	public int AI_GET_UNIATAB_DW(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIATAB_DW", [new IntParam(param0)]);
	public int AI_GET_UNIWEAK(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIWEAK", [new IntParam(param0)]);
	public int AI_GET_UNIWEAK_ST(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIWEAK_ST", [new IntParam(param0)]);
	public int AI_GET_UNIWEAK_DW(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIWEAK_DW", [new IntParam(param0)]);
	public int AI_GET_UNIHANSYA(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIHANSYA", [new IntParam(param0)]);
	public int AI_GET_UNIKYUSYU(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIKYUSYU", [new IntParam(param0)]);
	public int AI_GET_UNIMUKOU(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIMUKOU", [new IntParam(param0)]);
	public int AI_GET_UNIRESIST(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIRESIST", [new IntParam(param0)]);
	public int AI_RND(int param0) =>
		FlowLib.InvokeInt("AI_RND", [new IntParam(param0)]);
	public int AI_GET_GLOBAL(int param0) =>
		FlowLib.InvokeInt("AI_GET_GLOBAL", [new IntParam(param0)]);
	public int BTL_GET_COUNTER(int param0) =>
		FlowLib.InvokeInt("BTL_GET_COUNTER", [new IntParam(param0)]);
	public int AI_SET_GLOBAL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_SET_GLOBAL", [new IntParam(param0), new IntParam(param1)]);
	public int BTL_SET_COUNTER(int param0, int param1) =>
		FlowLib.InvokeInt("BTL_SET_COUNTER", [new IntParam(param0), new IntParam(param1)]);
	public int BTL_GET_CURRENT_CHARAID() =>
		FlowLib.InvokeInt("BTL_GET_CURRENT_CHARAID", []);
	public void CALL_FIELDBATTLE(int param0) =>
		FlowLib.InvokeVoid("CALL_FIELDBATTLE", [new IntParam(param0)]);
	public void CALL_EVENTBATTLE(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CALL_EVENTBATTLE", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int AI_CHK_MYGROUP() =>
		FlowLib.InvokeInt("AI_CHK_MYGROUP", []);
	public int AI_CHK_FRGROUP() =>
		FlowLib.InvokeInt("AI_CHK_FRGROUP", []);
	public int AI_CHK_ENGROUP() =>
		FlowLib.InvokeInt("AI_CHK_ENGROUP", []);
	public void AI_ACT_ESCAPE() =>
		FlowLib.InvokeVoid("AI_ACT_ESCAPE", []);
	public void AI_ADD_REINFORCEMENT(int param0) =>
		FlowLib.InvokeVoid("AI_ADD_REINFORCEMENT", [new IntParam(param0)]);
	public int AI_CHK_SUMMONCNT(int param0) =>
		FlowLib.InvokeInt("AI_CHK_SUMMONCNT", [new IntParam(param0)]);
	public void AI_TAR_HANSYA(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_HANSYA", [new IntParam(param0)]);
	public void AI_TAR_KYUSYU(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_KYUSYU", [new IntParam(param0)]);
	public void AI_TAR_MUKOU(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_MUKOU", [new IntParam(param0)]);
	public void AI_TAR_WEAK(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_WEAK", [new IntParam(param0)]);
	public void AI_TAR_NOTHANSYA(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTHANSYA", [new IntParam(param0)]);
	public void AI_TAR_NOTKYUSYU(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTKYUSYU", [new IntParam(param0)]);
	public void AI_TAR_NOTMUKOU(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTMUKOU", [new IntParam(param0)]);
	public void AI_TAR_NOTWEAK(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTWEAK", [new IntParam(param0)]);
	public void AI_TAR_HANSYA_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_HANSYA_ST", [new IntParam(param0)]);
	public void AI_TAR_KYUSYU_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_KYUSYU_ST", [new IntParam(param0)]);
	public void AI_TAR_MUKOU_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_MUKOU_ST", [new IntParam(param0)]);
	public void AI_TAR_WEAK_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_WEAK_ST", [new IntParam(param0)]);
	public void AI_TAR_NOTHANSYA_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTHANSYA_ST", [new IntParam(param0)]);
	public void AI_TAR_NOTKYUSYU_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTKYUSYU_ST", [new IntParam(param0)]);
	public void AI_TAR_NOTMUKOU_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTMUKOU_ST", [new IntParam(param0)]);
	public void AI_TAR_NOTWEAK_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTWEAK_ST", [new IntParam(param0)]);
	public void AI_ACT_WAIT() =>
		FlowLib.InvokeVoid("AI_ACT_WAIT", []);
	public void AI_ACT_SKIP() =>
		FlowLib.InvokeVoid("AI_ACT_SKIP", []);
	public void AI_ACT_WAIT2(int param0) =>
		FlowLib.InvokeVoid("AI_ACT_WAIT2", [new IntParam(param0)]);
	public void BTL_SHUFFLE_DECIDE_MAJORARCANA() =>
		FlowLib.InvokeVoid("BTL_SHUFFLE_DECIDE_MAJORARCANA", []);
	public void BTL_SHUFFLE_CLEAN_FLAG_ALL() =>
		FlowLib.InvokeVoid("BTL_SHUFFLE_CLEAN_FLAG_ALL", []);
	public void BTL_SHUFFLE_CLEAN_FLAG_ENTRANCE() =>
		FlowLib.InvokeVoid("BTL_SHUFFLE_CLEAN_FLAG_ENTRANCE", []);
	public int AI_CHK_FMTPINCH() =>
		FlowLib.InvokeInt("AI_CHK_FMTPINCH", []);
	public int AI_CHK_FMTADVANTAGE() =>
		FlowLib.InvokeInt("AI_CHK_FMTADVANTAGE", []);
	public int AI_CHK_FMTNML() =>
		FlowLib.InvokeInt("AI_CHK_FMTNML", []);
	public int AI_CHK_FRALLHP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRALLHP", [new IntParam(param0)]);
	public int AI_CHK_ENALLHP(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENALLHP", [new IntParam(param0)]);
	public int AI_CHK_ENBAD_ALL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENBAD_ALL", [new IntParam(param0)]);
	public int AI_CHK_FRBAD_NOTALL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRBAD_NOTALL", [new IntParam(param0)]);
	public int AI_CHK_ENBAD_NOTALL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENBAD_NOTALL", [new IntParam(param0)]);
	public int AI_CHK_MYID(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYID", [new IntParam(param0)]);
	public int AI_CHK_MYTAISEI(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYTAISEI", [new IntParam(param0)]);
	public int AI_CHK_FRTAISEI(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRTAISEI", [new IntParam(param0)]);
	public int AI_CHK_FRWEAK_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRWEAK_ST", [new IntParam(param0)]);
	public int AI_CHK_ENWEAK_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENWEAK_ST", [new IntParam(param0)]);
	public int AI_CHK_FRMUKOU_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRMUKOU_ST", [new IntParam(param0)]);
	public int AI_CHK_ENMUKOU_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENMUKOU_ST", [new IntParam(param0)]);
	public int AI_CHK_FRTAISEI_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRTAISEI_ST", [new IntParam(param0)]);
	public int AI_CHK_ENTAISEI_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENTAISEI_ST", [new IntParam(param0)]);
	public int AI_CHK_FRHANSYA_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRHANSYA_ST", [new IntParam(param0)]);
	public int AI_CHK_ENHANSYA_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENHANSYA_ST", [new IntParam(param0)]);
	public int AI_CHK_FRKYUSYU_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRKYUSYU_ST", [new IntParam(param0)]);
	public int AI_CHK_ENKYUSYU_ST(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENKYUSYU_ST", [new IntParam(param0)]);
	public int AI_CHK_MYUSEATTR(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYUSEATTR", [new IntParam(param0)]);
	public int AI_CHK_FRUSEATTR(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRUSEATTR", [new IntParam(param0)]);
	public int AI_CHK_ENUSEATTR(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENUSEATTR", [new IntParam(param0)]);
	public int AI_CHK_MYABLESKIL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYABLESKIL", [new IntParam(param0)]);
	public int AI_CHK_MYATTRSKIL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MYATTRSKIL", [new IntParam(param0)]);
	public int AI_CHK_MYHREC() =>
		FlowLib.InvokeInt("AI_CHK_MYHREC", []);
	public int AI_CHK_SUMMONED() =>
		FlowLib.InvokeInt("AI_CHK_SUMMONED", []);
	public int AI_CHK_ENCOUNT(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ENCOUNT", [new IntParam(param0)]);
	public int AI_TAR_MAN_RND() =>
		FlowLib.InvokeInt("AI_TAR_MAN_RND", []);
	public int AI_TAR_WOMAN_RND() =>
		FlowLib.InvokeInt("AI_TAR_WOMAN_RND", []);
	public int AI_TAR_NOTSUPPORTID(int param0) =>
		FlowLib.InvokeInt("AI_TAR_NOTSUPPORTID", [new IntParam(param0)]);
	public int AI_TAR_NOTBADID(int param0) =>
		FlowLib.InvokeInt("AI_TAR_NOTBADID", [new IntParam(param0)]);
	public int AI_CHK_FRIDSP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDSP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDLV_O(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDLV_O", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDUSEATTR(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDUSEATTR", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDUSEGROUP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDUSEGROUP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRIDHREC(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_FRIDHREC", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDHP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDHP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDSP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDSP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDLV_O(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDLV_O", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDBAD(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDBAD", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDBAD_ALL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDBAD_ALL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDHOJO(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDHOJO", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDWEAK(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDWEAK", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDMUKOU(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDMUKOU", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDHANSYA(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDHANSYA", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDKYUSYU(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDKYUSYU", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDUSESKIL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDUSESKIL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDUSEATTR(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDUSEATTR", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDUSEGROUP(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDUSEGROUP", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ENIDHREC(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_ENIDHREC", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_SEQUENCE(int param0) =>
		FlowLib.InvokeInt("AI_CHK_SEQUENCE", [new IntParam(param0)]);
	public int AI_CHK_TURNEQUAL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_TURNEQUAL", [new IntParam(param0)]);
	public int AI_CHK_TURNDIVI(int param0) =>
		FlowLib.InvokeInt("AI_CHK_TURNDIVI", [new IntParam(param0)]);
	public int AI_GET_P_ORDER(int param0) =>
		FlowLib.InvokeInt("AI_GET_P_ORDER", [new IntParam(param0)]);
	public int AI_GET_MY_ID() =>
		FlowLib.InvokeInt("AI_GET_MY_ID", []);
	public int AI_GET_UNI(int param0, int param1) =>
		FlowLib.InvokeInt("AI_GET_UNI", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_COUNTDOWN_START(int param0) =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_START", [new IntParam(param0)]);
	public void BTL_COUNTDOWN_STOP() =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_STOP", []);
	public void BTL_COUNTDOWN_PLAY() =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_PLAY", []);
	public void BTL_COUNTDOWN_SPEED(int param0) =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_SPEED", [new IntParam(param0)]);
	public void BTL_CINEMASCOPE_START() =>
		FlowLib.InvokeVoid("BTL_CINEMASCOPE_START", []);
	public void BTL_CINEMASCOPE_END() =>
		FlowLib.InvokeVoid("BTL_CINEMASCOPE_END", []);
	public int BTL_CUTSCENE_LOAD(int param0) =>
		FlowLib.InvokeInt("BTL_CUTSCENE_LOAD", [new IntParam(param0)]);
	public void BTL_CUTSCENE_LOADSYNC(int param0) =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_LOADSYNC", [new IntParam(param0)]);
	public void BTL_CUTSCENE_PLAY(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_PLAY", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public void BTL_CUTSCENE_SYNC(int param0) =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_SYNC", [new IntParam(param0)]);
	public void BTL_CUTSCENE_END(int param0) =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_END", [new IntParam(param0)]);
	public void BTL_COUNTDOWN_VISIBLE() =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_VISIBLE", []);
	public void BTL_COUNTDOWN_HIDDEN() =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_HIDDEN", []);
	public void BTL_UI_VISIBLE() =>
		FlowLib.InvokeVoid("BTL_UI_VISIBLE", []);
	public void BTL_UI_HIDDEN() =>
		FlowLib.InvokeVoid("BTL_UI_HIDDEN", []);
	public void BTL_PLAY_BG_RAIL_ANIM(int param0) =>
		FlowLib.InvokeVoid("BTL_PLAY_BG_RAIL_ANIM", [new IntParam(param0)]);
	public void BTL_REQ_ASSIST(int param0, int param1, float param2) =>
		FlowLib.InvokeVoid("BTL_REQ_ASSIST", [new IntParam(param0), new IntParam(param1), new FloatParam(param2)]);
	public void BTL_PLAY_BG_STRAP_ANIM(int param0) =>
		FlowLib.InvokeVoid("BTL_PLAY_BG_STRAP_ANIM", [new IntParam(param0)]);
	public void AI_ACT_SKILL_EX(int param0, int param1) =>
		FlowLib.InvokeVoid("AI_ACT_SKILL_EX", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_PLAY_BG_ANIM(int param0, int param1) =>
		FlowLib.InvokeVoid("BTL_PLAY_BG_ANIM", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_CUTSCENE_PLAY_ACTOR3(int param0, int param1, int param2, int param3, int param4, int param5, int param6) =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_PLAY_ACTOR3", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5), new IntParam(param6)]);
	public int AI_GET_ENID_ACTTURNCOUNT(int param0) =>
		FlowLib.InvokeInt("AI_GET_ENID_ACTTURNCOUNT", [new IntParam(param0)]);
	public void AI_SET_ENID_MAXACTTURN(int param0, int param1) =>
		FlowLib.InvokeVoid("AI_SET_ENID_MAXACTTURN", [new IntParam(param0), new IntParam(param1)]);
	public int AI_GET_FRID_ACTTURNCOUNT(int param0) =>
		FlowLib.InvokeInt("AI_GET_FRID_ACTTURNCOUNT", [new IntParam(param0)]);
	public void AI_SET_FRID_MAXACTTURN(int param0, int param1) =>
		FlowLib.InvokeVoid("AI_SET_FRID_MAXACTTURN", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_FRBAD_ALL(int param0) =>
		FlowLib.InvokeInt("AI_CHK_FRBAD_ALL", [new IntParam(param0)]);
	public void BTL_REQ_ASSIST_SEQ(int param0, int param1, float param2) =>
		FlowLib.InvokeVoid("BTL_REQ_ASSIST_SEQ", [new IntParam(param0), new IntParam(param1), new FloatParam(param2)]);
	public int BTL_CHK_PARTYIN_ID(int param0) =>
		FlowLib.InvokeInt("BTL_CHK_PARTYIN_ID", [new IntParam(param0)]);
	public void AI_ACT_TAKEOVER(int param0) =>
		FlowLib.InvokeVoid("AI_ACT_TAKEOVER", [new IntParam(param0)]);
	public int AI_CHK_TAKEOVER(int param0) =>
		FlowLib.InvokeInt("AI_CHK_TAKEOVER", [new IntParam(param0)]);
	public int BTL_GET_NYX_ID() =>
		FlowLib.InvokeInt("BTL_GET_NYX_ID", []);
	public int AI_CHK_UNIATTACK(int param0) =>
		FlowLib.InvokeInt("AI_CHK_UNIATTACK", [new IntParam(param0)]);
	public void AI_TAR_UID(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_UID", [new IntParam(param0)]);
	public int AI_GET_P_NOW_HP(int param0) =>
		FlowLib.InvokeInt("AI_GET_P_NOW_HP", [new IntParam(param0)]);
	public int AI_GET_P_NOW_SP(int param0) =>
		FlowLib.InvokeInt("AI_GET_P_NOW_SP", [new IntParam(param0)]);
	public int AI_GET_P_MAX_HP(int param0) =>
		FlowLib.InvokeInt("AI_GET_P_MAX_HP", [new IntParam(param0)]);
	public int AI_GET_P_MAX_SP(int param0) =>
		FlowLib.InvokeInt("AI_GET_P_MAX_SP", [new IntParam(param0)]);
	public int AI_GET_UNIHPMIN() =>
		FlowLib.InvokeInt("AI_GET_UNIHPMIN", []);
	public int AI_CHK_UNIANALYZE_OPEN(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_UNIANALYZE_OPEN", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_ID_FRTARGET(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ID_FRTARGET", [new IntParam(param0)]);
	public int AI_GET_UNI_NOANALYZE(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNI_NOANALYZE", [new IntParam(param0)]);
	public int AI_GET_UNI_ATTACK(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNI_ATTACK", [new IntParam(param0)]);
	public int AI_CHK_UNINOMAL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_UNINOMAL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_GET_FRBAD_ON(int param0) =>
		FlowLib.InvokeInt("AI_GET_FRBAD_ON", [new IntParam(param0)]);
	public int AI_GET_ENBAD_ON(int param0) =>
		FlowLib.InvokeInt("AI_GET_ENBAD_ON", [new IntParam(param0)]);
	public int AI_CHK_UNIHOJO(int param0, int param1) =>
		FlowLib.InvokeInt("AI_CHK_UNIHOJO", [new IntParam(param0), new IntParam(param1)]);
	public int AI_GET_ATTRSKIL(int param0, int param1) =>
		FlowLib.InvokeInt("AI_GET_ATTRSKIL", [new IntParam(param0), new IntParam(param1)]);
	public int AI_CHK_EXCEPT_ENCOUNT() =>
		FlowLib.InvokeInt("AI_CHK_EXCEPT_ENCOUNT", []);
	public int AI_CHK_ABLEWEAK(int param0) =>
		FlowLib.InvokeInt("AI_CHK_ABLEWEAK", [new IntParam(param0)]);
	public int AI_GET_UNIBESTATTRSKIL(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("AI_GET_UNIBESTATTRSKIL", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int AI_ACT_HIGHSKILL(int param0) =>
		FlowLib.InvokeInt("AI_ACT_HIGHSKILL", [new IntParam(param0)]);
	public int AI_ACT_HEAL() =>
		FlowLib.InvokeInt("AI_ACT_HEAL", []);
	public int AI_ACT_ATTACK_WEAK() =>
		FlowLib.InvokeInt("AI_ACT_ATTACK_WEAK", []);
	public int AI_ACT_REZ() =>
		FlowLib.InvokeInt("AI_ACT_REZ", []);
	public int AI_ACT_BADSKILL() =>
		FlowLib.InvokeInt("AI_ACT_BADSKILL", []);
	public int AI_ACT_BADSTATE() =>
		FlowLib.InvokeInt("AI_ACT_BADSTATE", []);
	public int AI_ACT_DEBUFF(int param0) =>
		FlowLib.InvokeInt("AI_ACT_DEBUFF", [new IntParam(param0)]);
	public int AI_ACT_FIXED() =>
		FlowLib.InvokeInt("AI_ACT_FIXED", []);
	public int AI_ACT_UNKNOWN_ATTR() =>
		FlowLib.InvokeInt("AI_ACT_UNKNOWN_ATTR", []);
	public int AI_CHK_THEURGIA() =>
		FlowLib.InvokeInt("AI_CHK_THEURGIA", []);
	public void AI_ACT_THEURGIA(int param0) =>
		FlowLib.InvokeVoid("AI_ACT_THEURGIA", [new IntParam(param0)]);
	public int AI_GET_UNIQUE_HIT_HPMIN(int param0) =>
		FlowLib.InvokeInt("AI_GET_UNIQUE_HIT_HPMIN", [new IntParam(param0)]);
	public void BTL_KEY_ENABLE(int param0, int param1) =>
		FlowLib.InvokeVoid("BTL_KEY_ENABLE", [new IntParam(param0), new IntParam(param1)]);
	public int AI_GET_ENCOUNT_ID() =>
		FlowLib.InvokeInt("AI_GET_ENCOUNT_ID", []);
	public void AI_SET_MANUAL_OPERATE(int param0, int param1) =>
		FlowLib.InvokeVoid("AI_SET_MANUAL_OPERATE", [new IntParam(param0), new IntParam(param1)]);
	public void AI_TAR_TAKAYAJOIN_ID(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_TAKAYAJOIN_ID", [new IntParam(param0)]);
	public void BTL_RELOCATION() =>
		FlowLib.InvokeVoid("BTL_RELOCATION", []);
	public void BTL_PLAY_EVENT_VOICE(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("BTL_PLAY_EVENT_VOICE", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void BTL_EVENT_RETURN_VALUE(int param0) =>
		FlowLib.InvokeVoid("BTL_EVENT_RETURN_VALUE", [new IntParam(param0)]);
	public int BTL_GET_ERZ_ID() =>
		FlowLib.InvokeInt("BTL_GET_ERZ_ID", []);
	public int AI_CHK_PREV_DAMAGE_ATTR(int param0) =>
		FlowLib.InvokeInt("AI_CHK_PREV_DAMAGE_ATTR", [new IntParam(param0)]);
	public void BTL_COUNTDOWN_REDUCE(int param0) =>
		FlowLib.InvokeVoid("BTL_COUNTDOWN_REDUCE", [new IntParam(param0)]);
	public int BTL_COUNTDOWN_TIME_GET(int param0) =>
		FlowLib.InvokeInt("BTL_COUNTDOWN_TIME_GET", [new IntParam(param0)]);
	public int BTL_TP_ANIMATION(int param0, int param1) =>
		FlowLib.InvokeInt("BTL_TP_ANIMATION", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_PARTYPANEL_DISP() =>
		FlowLib.InvokeVoid("BTL_PARTYPANEL_DISP", []);
	public void BTL_PARTYPANEL_HIDE() =>
		FlowLib.InvokeVoid("BTL_PARTYPANEL_HIDE", []);
	public void BTL_END_FADE_IN() =>
		FlowLib.InvokeVoid("BTL_END_FADE_IN", []);
	public void BTL_RELOCATION_BTLEND() =>
		FlowLib.InvokeVoid("BTL_RELOCATION_BTLEND", []);
	public void BTL_SET_FORCE_MSG_MODE(int param0) =>
		FlowLib.InvokeVoid("BTL_SET_FORCE_MSG_MODE", [new IntParam(param0)]);
	public void BTL_TUTORIAL_REQUEST(int param0, int param1) =>
		FlowLib.InvokeVoid("BTL_TUTORIAL_REQUEST", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_CUTSCENE_ALLLOAD() =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_ALLLOAD", []);
	public void BTL_CUTSCENE_ALLLOADSYNC() =>
		FlowLib.InvokeVoid("BTL_CUTSCENE_ALLLOADSYNC", []);
	public void AI_TAR_BAD_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_BAD_ST", [new IntParam(param0)]);
	public void AI_TAR_NOTBAD_ST(int param0) =>
		FlowLib.InvokeVoid("AI_TAR_NOTBAD_ST", [new IntParam(param0)]);
	public void BTL_SET_SHOW_BADSTATUS_ICON(int param0, int param1) =>
		FlowLib.InvokeVoid("BTL_SET_SHOW_BADSTATUS_ICON", [new IntParam(param0), new IntParam(param1)]);
	public void BTL_WIPE_IN() =>
		FlowLib.InvokeVoid("BTL_WIPE_IN", []);
	public void BTL_WIPE_SYNC() =>
		FlowLib.InvokeVoid("BTL_WIPE_SYNC", []);
	public int BTL_CHK_HIGH_ANALYZE() =>
		FlowLib.InvokeInt("BTL_CHK_HIGH_ANALYZE", []);
	public void CALL_FIELDBATTLE_OF_SERIALENCOUNT(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CALL_FIELDBATTLE_OF_SERIALENCOUNT", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int AI_CHK_CONTINUOUS_ENCOUNTER(int param0) =>
		FlowLib.InvokeInt("AI_CHK_CONTINUOUS_ENCOUNTER", [new IntParam(param0)]);
	public int AI_CHK_MONADO_DIFFICULTY(int param0) =>
		FlowLib.InvokeInt("AI_CHK_MONADO_DIFFICULTY", [new IntParam(param0)]);
	public int DUNGEON_CHECK_GK_BEFORE_FLOOR() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_GK_BEFORE_FLOOR", []);
	public void FLD_LOCAL_FLAG_ON(int param0) =>
		FlowLib.InvokeVoid("FLD_LOCAL_FLAG_ON", [new IntParam(param0)]);
	public void FLD_LOCAL_FLAG_OFF(int param0) =>
		FlowLib.InvokeVoid("FLD_LOCAL_FLAG_OFF", [new IntParam(param0)]);
	public int FLD_LOCAL_FLAG_CHECK(int param0) =>
		FlowLib.InvokeInt("FLD_LOCAL_FLAG_CHECK", [new IntParam(param0)]);
	public void FLD_LOCAL_COUNTER_SET(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_LOCAL_COUNTER_SET", [new IntParam(param0), new IntParam(param1)]);
	public int FLD_LOCAL_COUNTER_GET(int param0) =>
		FlowLib.InvokeInt("FLD_LOCAL_COUNTER_GET", [new IntParam(param0)]);
	public void CALL_FIELD(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CALL_FIELD", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void CALL_KEYFREE_EVENT(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeVoid("CALL_KEYFREE_EVENT", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void CALL_DUNGEON(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CALL_DUNGEON", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void DUNGEON_NEXTFLOOR() =>
		FlowLib.InvokeVoid("DUNGEON_NEXTFLOOR", []);
	public void DUNGEON_TRANSFER(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_TRANSFER", [new IntParam(param0)]);
	public void DUNGEON_CONTINUATION() =>
		FlowLib.InvokeVoid("DUNGEON_CONTINUATION", []);
	public void DUNGEON_EVACUATION() =>
		FlowLib.InvokeVoid("DUNGEON_EVACUATION", []);
	public int GET_FIELD_PARTS_ID() =>
		FlowLib.InvokeInt("GET_FIELD_PARTS_ID", []);
	public int FLD_GET_MAJOR() =>
		FlowLib.InvokeInt("FLD_GET_MAJOR", []);
	public int FLD_GET_MINOR() =>
		FlowLib.InvokeInt("FLD_GET_MINOR", []);
	public int FLD_GET_KEYFREE_EVENT_ID() =>
		FlowLib.InvokeInt("FLD_GET_KEYFREE_EVENT_ID", []);
	public void GOTO_TARTARUS() =>
		FlowLib.InvokeVoid("GOTO_TARTARUS", []);
	public void FLD_RETURN_FIELD() =>
		FlowLib.InvokeVoid("FLD_RETURN_FIELD", []);
	public int GET_FIELD_START_ID() =>
		FlowLib.InvokeInt("GET_FIELD_START_ID", []);
	public void DUNGEON_MOVE_FDOOR() =>
		FlowLib.InvokeVoid("DUNGEON_MOVE_FDOOR", []);
	public void FLD_SOUND_VOICE_SETUP(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_SOUND_VOICE_SETUP", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_SOUND_VOICE_SYNC() =>
		FlowLib.InvokeVoid("FLD_SOUND_VOICE_SYNC", []);
	public void FLD_SOUND_VOICE_FREE() =>
		FlowLib.InvokeVoid("FLD_SOUND_VOICE_FREE", []);
	public int DUNGEON_GET_FLOORNO() =>
		FlowLib.InvokeInt("DUNGEON_GET_FLOORNO", []);
	public int DUNGEON_GET_ARRIVAL_FLOORNO() =>
		FlowLib.InvokeInt("DUNGEON_GET_ARRIVAL_FLOORNO", []);
	public int DUNGEON_CHECK_MISSING_FLOOR() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_MISSING_FLOOR", []);
	public int FLD_GET_FAM_INDEX_OBJECT(int param0) =>
		FlowLib.InvokeInt("FLD_GET_FAM_INDEX_OBJECT", [new IntParam(param0)]);
	public int FLD_GET_FAM_INDEX_NPC(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("FLD_GET_FAM_INDEX_NPC", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int FLD_GET_FAM_INDEX_CMMNPC(int param0, int param1) =>
		FlowLib.InvokeInt("FLD_GET_FAM_INDEX_CMMNPC", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_FAM_ANIM(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FLD_FAM_ANIM", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FLD_FAM_ACTOR_SET_VISIBLE(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_FAM_ACTOR_SET_VISIBLE", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_START_FIELD_EVENT(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_START_FIELD_EVENT", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_PC_MODEL_SET_POS(int param0) =>
		FlowLib.InvokeVoid("FLD_PC_MODEL_SET_POS", [new IntParam(param0)]);
	public void FLD_REQ_BGM() =>
		FlowLib.InvokeVoid("FLD_REQ_BGM", []);
	public void DUNGEON_DESTORY_DIRECT_SYMBOL(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_DESTORY_DIRECT_SYMBOL", [new IntParam(param0)]);
	public void DUNGEON_SPSKILL_TARTARUSSEARCH() =>
		FlowLib.InvokeVoid("DUNGEON_SPSKILL_TARTARUSSEARCH", []);
	public void DUNGEON_SPSKILL_JAMMING() =>
		FlowLib.InvokeVoid("DUNGEON_SPSKILL_JAMMING", []);
	public void DUNGEON_SPSKILL_ESCAPEROAD() =>
		FlowLib.InvokeVoid("DUNGEON_SPSKILL_ESCAPEROAD", []);
	public void DUNGEON_PARTY_DISPERSED(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_PARTY_DISPERSED", [new IntParam(param0)]);
	public void DUNGEON_PARTY_ASSEMBLE() =>
		FlowLib.InvokeVoid("DUNGEON_PARTY_ASSEMBLE", []);
	public int DUNGEON_TBOX_GET_ITEM_ID(int param0) =>
		FlowLib.InvokeInt("DUNGEON_TBOX_GET_ITEM_ID", [new IntParam(param0)]);
	public int DUNGEON_TBOX_GET_ITEM_NUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_TBOX_GET_ITEM_NUM", [new IntParam(param0)]);
	public int DUNGEON_TBOX_GET_MONEY(int param0) =>
		FlowLib.InvokeInt("DUNGEON_TBOX_GET_MONEY", [new IntParam(param0)]);
	public void DUNGEON_REMOVE_TBOX_ITEMINFO(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_REMOVE_TBOX_ITEMINFO", [new IntParam(param0)]);
	public void FLD_CHARA_WALK_TRANSLATE(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeVoid("FLD_CHARA_WALK_TRANSLATE", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void FLD_CHARA_SYNC_TRANSLATE() =>
		FlowLib.InvokeVoid("FLD_CHARA_SYNC_TRANSLATE", []);
	public int DUNGEON_TBOX_GET_TYPE(int param0) =>
		FlowLib.InvokeInt("DUNGEON_TBOX_GET_TYPE", [new IntParam(param0)]);
	public int DUNGEON_PARTNER_TBOX_NUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_PARTNER_TBOX_NUM", [new IntParam(param0)]);
	public int DUNGEON_PARTNER_ITEM_ID(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_PARTNER_ITEM_ID", [new IntParam(param0), new IntParam(param1)]);
	public int DUNGEON_PARTNER_ITEM_NUM(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_PARTNER_ITEM_NUM", [new IntParam(param0), new IntParam(param1)]);
	public int DUNGEON_PARTNER_MONEY(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_PARTNER_MONEY", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_ACCIDENT_CHANGE_SYMBOL(int param0, int param1) =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_CHANGE_SYMBOL", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_ACCIDENT_DARK_ZONE() =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_DARK_ZONE", []);
	public void DUNGEON_ACCIDENT_PARTY_DIVISION() =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_PARTY_DIVISION", []);
	public void DUNGEON_ACCIDENT_ABNORMAL_STATE(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_ABNORMAL_STATE", [new IntParam(param0)]);
	public void DUNGEON_ACCIDENT_IMMEDJATE_EFFECT(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_IMMEDJATE_EFFECT", [new IntParam(param0)]);
	public void DUNGEON_ACCIDENT_LIMITED_BATTLE() =>
		FlowLib.InvokeVoid("DUNGEON_ACCIDENT_LIMITED_BATTLE", []);
	public void DUNGEON_OPEN_TBOX(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_OPEN_TBOX", [new IntParam(param0)]);
	public void FLD_NPC_FLAG_ON(int param0) =>
		FlowLib.InvokeVoid("FLD_NPC_FLAG_ON", [new IntParam(param0)]);
	public void FLD_NPC_FLAG_OFF(int param0) =>
		FlowLib.InvokeVoid("FLD_NPC_FLAG_OFF", [new IntParam(param0)]);
	public int FLD_NPC_FLAG_CHECK(int param0) =>
		FlowLib.InvokeInt("FLD_NPC_FLAG_CHECK", [new IntParam(param0)]);
	public void DUNGEON_MOVE_FREEID(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_MOVE_FREEID", [new IntParam(param0)]);
	public void DUNGEON_INFO_SUPPORT(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeVoid("DUNGEON_INFO_SUPPORT", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public void DUNGEON_BEGINEVENT() =>
		FlowLib.InvokeVoid("DUNGEON_BEGINEVENT", []);
	public void DUNGEON_ENDEVENT() =>
		FlowLib.InvokeVoid("DUNGEON_ENDEVENT", []);
	public void SET_FIELD_PARTS_ID(int param0) =>
		FlowLib.InvokeVoid("SET_FIELD_PARTS_ID", [new IntParam(param0)]);
	public void FLDANIMOBJ_REQUEST_ANIMATION(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FLDANIMOBJ_REQUEST_ANIMATION", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int DUNGEON_CHECK_OPEN_FDOOR() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_OPEN_FDOOR", []);
	public int DUNGEON_PARTNER_ITEM_PAC_NUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_PARTNER_ITEM_PAC_NUM", [new IntParam(param0)]);
	public void DUNGEON_PARTNER_ITEM_REFLECT(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_PARTNER_ITEM_REFLECT", [new IntParam(param0)]);
	public int DUNGEON_CHECK_GATEKEEPER_FLOOR() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_GATEKEEPER_FLOOR", []);
	public int DUNGEON_CHECK_FDOOR_FLOOR() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_FDOOR_FLOOR", []);
	public void FLD_FAM_SYNC_ANIM(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_SYNC_ANIM", [new IntParam(param0)]);
	public void DUNGEON_ATOMFOG_HIDDEN(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_ATOMFOG_HIDDEN", [new IntParam(param0)]);
	public int DUNGEON_TBOX_CHECK_ENCOUNT(int param0) =>
		FlowLib.InvokeInt("DUNGEON_TBOX_CHECK_ENCOUNT", [new IntParam(param0)]);
	public void FLD_TV_PROGRAM_ON() =>
		FlowLib.InvokeVoid("FLD_TV_PROGRAM_ON", []);
	public void FLD_TV_PROGRAM_OFF() =>
		FlowLib.InvokeVoid("FLD_TV_PROGRAM_OFF", []);
	public int FLD_TV_PROGRAM_CHECK() =>
		FlowLib.InvokeInt("FLD_TV_PROGRAM_CHECK", []);
	public void FLD_TV_MODEL_REQ_ANIME(int param0) =>
		FlowLib.InvokeVoid("FLD_TV_MODEL_REQ_ANIME", [new IntParam(param0)]);
	public void FLD_COMSE_PLAY(int param0) =>
		FlowLib.InvokeVoid("FLD_COMSE_PLAY", [new IntParam(param0)]);
	public void FLD_COMSE_STOP() =>
		FlowLib.InvokeVoid("FLD_COMSE_STOP", []);
	public int DUNGEON_FLOORFLAGS_CHECK_EXIST(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_FLOORFLAGS_CHECK_EXIST", [new IntParam(param0), new IntParam(param1)]);
	public int DUNGEON_FLOORFLAGS_CHECK_FLAG(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_FLOORFLAGS_CHECK_FLAG", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_FLOORFLAGS_SET_FLAG(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("DUNGEON_FLOORFLAGS_SET_FLAG", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int FLD_MAIL_ORDER_CHECK() =>
		FlowLib.InvokeInt("FLD_MAIL_ORDER_CHECK", []);
	public int FLD_MAIL_ORDER_RECIEVE_CHECK() =>
		FlowLib.InvokeInt("FLD_MAIL_ORDER_RECIEVE_CHECK", []);
	public int FLD_MAIL_ORDER_GET_INDEX(int param0) =>
		FlowLib.InvokeInt("FLD_MAIL_ORDER_GET_INDEX", [new IntParam(param0)]);
	public void FLD_MAIL_ORDER_VSET(int param0) =>
		FlowLib.InvokeVoid("FLD_MAIL_ORDER_VSET", [new IntParam(param0)]);
	public int FLD_MAIL_ORDER_GET_MONEY(int param0) =>
		FlowLib.InvokeInt("FLD_MAIL_ORDER_GET_MONEY", [new IntParam(param0)]);
	public void FLD_MAIL_ORDER_SET_ITEM(int param0) =>
		FlowLib.InvokeVoid("FLD_MAIL_ORDER_SET_ITEM", [new IntParam(param0)]);
	public int FLD_MAIL_ORDER_GET_ITEM_MSGID(int param0) =>
		FlowLib.InvokeInt("FLD_MAIL_ORDER_GET_ITEM_MSGID", [new IntParam(param0)]);
	public void FLD_MAIL_ORDER_CALL_SCRIPT() =>
		FlowLib.InvokeVoid("FLD_MAIL_ORDER_CALL_SCRIPT", []);
	public void FLD_MAIL_ORDER_PAY_THE_PRICE(int param0) =>
		FlowLib.InvokeVoid("FLD_MAIL_ORDER_PAY_THE_PRICE", [new IntParam(param0)]);
	public void FLD_CAMERA_LOCK_INTERP(float param0, float param1, float param2, float param3, float param4, float param5, float param6) =>
		FlowLib.InvokeVoid("FLD_CAMERA_LOCK_INTERP", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4), new FloatParam(param5), new FloatParam(param6)]);
	public void FLD_CAMERA_LOCK_SYNC_INTERP() =>
		FlowLib.InvokeVoid("FLD_CAMERA_LOCK_SYNC_INTERP", []);
	public void FLD_CAMERA_DEFAULT_INTERP(float param0) =>
		FlowLib.InvokeVoid("FLD_CAMERA_DEFAULT_INTERP", [new FloatParam(param0)]);
	public void FLD_CAMERA_LOCK() =>
		FlowLib.InvokeVoid("FLD_CAMERA_LOCK", []);
	public void FLD_CAMERA_UNLOCK() =>
		FlowLib.InvokeVoid("FLD_CAMERA_UNLOCK", []);
	public int FLD_GET_FAM_INDEX_PLAYER(int param0) =>
		FlowLib.InvokeInt("FLD_GET_FAM_INDEX_PLAYER", [new IntParam(param0)]);
	public void FLD_OPEN_ORD_DOOR_FADE(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeVoid("FLD_OPEN_ORD_DOOR_FADE", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void FLD_PC_MODEL_SET_ROTATOR(float param0, float param1, float param2) =>
		FlowLib.InvokeVoid("FLD_PC_MODEL_SET_ROTATOR", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2)]);
	public void FLD_SET_DOOR_STATE(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_SET_DOOR_STATE", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_SET_HERO_NO_WEAPON() =>
		FlowLib.InvokeVoid("FLD_SET_HERO_NO_WEAPON", []);
	public void FLD_SET_HERO_NO_FOLLOWER() =>
		FlowLib.InvokeVoid("FLD_SET_HERO_NO_FOLLOWER", []);
	public void DUNGEON_FIELDBATTLE_END() =>
		FlowLib.InvokeVoid("DUNGEON_FIELDBATTLE_END", []);
	public int DUNGEON_GET_ENEMY_NUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_GET_ENEMY_NUM", [new IntParam(param0)]);
	public void FLD_START_BOSS(int param0) =>
		FlowLib.InvokeVoid("FLD_START_BOSS", [new IntParam(param0)]);
	public int DUNGEON_SET_ENEMY_CONDITION(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("DUNGEON_SET_ENEMY_CONDITION", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FLD_FAM_SET_DELAY_STOP(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_SET_DELAY_STOP", [new IntParam(param0)]);
	public void FLD_FAM_CLEAR_DELAY_STOP(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_CLEAR_DELAY_STOP", [new IntParam(param0)]);
	public void FLD_FAM_CLEAR_DELAY_STOP_ALL() =>
		FlowLib.InvokeVoid("FLD_FAM_CLEAR_DELAY_STOP_ALL", []);
	public void DUNGEON_RETRY_BACKUP() =>
		FlowLib.InvokeVoid("DUNGEON_RETRY_BACKUP", []);
	public void DUNGEON_RETRY_RESTORE() =>
		FlowLib.InvokeVoid("DUNGEON_RETRY_RESTORE", []);
	public void FLD_FAM_ICON_START(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_FAM_ICON_START", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_FAM_ICON_START_EX(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FLD_FAM_ICON_START_EX", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FLD_FAM_ICON_END(int param0, int param1) =>
		FlowLib.InvokeVoid("FLD_FAM_ICON_END", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_FAM_ICON_SET_SCALE(int param0, float param1) =>
		FlowLib.InvokeVoid("FLD_FAM_ICON_SET_SCALE", [new IntParam(param0), new FloatParam(param1)]);
	public void DUNGEON_SET_FLOOR_OPEN(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SET_FLOOR_OPEN", [new IntParam(param0)]);
	public int DUNGEON_CHECK_FLOOR_OPEN(int param0) =>
		FlowLib.InvokeInt("DUNGEON_CHECK_FLOOR_OPEN", [new IntParam(param0)]);
	public void DUNGEON_FIELDBATTLE_CLEAR_KEYLOCK() =>
		FlowLib.InvokeVoid("DUNGEON_FIELDBATTLE_CLEAR_KEYLOCK", []);
	public void DUNGEON_INFO_SUPPORT_TALK(int param0, int param1, int param2, int param3, int param4, int param5) =>
		FlowLib.InvokeVoid("DUNGEON_INFO_SUPPORT_TALK", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5)]);
	public int DUNGEON_GET_MISSING_ID() =>
		FlowLib.InvokeInt("DUNGEON_GET_MISSING_ID", []);
	public int DUNGEON_INFO_SUPPORT_WAIT(int param0, int param1, int param2, int param3) =>
		FlowLib.InvokeInt("DUNGEON_INFO_SUPPORT_WAIT", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3)]);
	public void DUNGEON_ROLLBACK() =>
		FlowLib.InvokeVoid("DUNGEON_ROLLBACK", []);
	public void DUNGEON_REAPER_APPEAR_TIME(float param0) =>
		FlowLib.InvokeVoid("DUNGEON_REAPER_APPEAR_TIME", [new FloatParam(param0)]);
	public void DUNGEON_REAPER_CONTINUE_APPEAR_TIME(float param0) =>
		FlowLib.InvokeVoid("DUNGEON_REAPER_CONTINUE_APPEAR_TIME", [new FloatParam(param0)]);
	public void DUNGEON_REAPER_SPAWN_START_PART() =>
		FlowLib.InvokeVoid("DUNGEON_REAPER_SPAWN_START_PART", []);
	public int DUNGEON_CHECK_PLAYER_START_PART() =>
		FlowLib.InvokeInt("DUNGEON_CHECK_PLAYER_START_PART", []);
	public void SCHE_CHECK_MORNING_EVENT_MSGREF(int param0, int param1) =>
		FlowLib.InvokeVoid("SCHE_CHECK_MORNING_EVENT_MSGREF", [new IntParam(param0), new IntParam(param1)]);
	public void SCHE_CHECK_TEACHING_EVENT_MSGREF(int param0, int param1) =>
		FlowLib.InvokeVoid("SCHE_CHECK_TEACHING_EVENT_MSGREF", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_SET_EVENT_TRANS_ORIGIN(int param0, int param1) =>
		FlowLib.InvokeVoid("DUNGEON_SET_EVENT_TRANS_ORIGIN", [new IntParam(param0), new IntParam(param1)]);
	public void FLD_FAM_FACE_ANIM(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FLD_FAM_FACE_ANIM", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FLD_FAM_NECK_ANIM(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FLD_FAM_NECK_ANIM", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FLD_FAM_SYNC_NECK_ANIM(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_SYNC_NECK_ANIM", [new IntParam(param0)]);
	public int DUNGEON_AUTO_RECOVER(int param0) =>
		FlowLib.InvokeInt("DUNGEON_AUTO_RECOVER", [new IntParam(param0)]);
	public void DUNGEON_SUPPORT_SKILL(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SUPPORT_SKILL", [new IntParam(param0)]);
	public int FLD_GET_FAM_INDEX_DOOR(int param0) =>
		FlowLib.InvokeInt("FLD_GET_FAM_INDEX_DOOR", [new IntParam(param0)]);
	public int DUNGEON_CHECK_PC_SKILL(int param0, int param1) =>
		FlowLib.InvokeInt("DUNGEON_CHECK_PC_SKILL", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_SET_PARTNER_POS(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SET_PARTNER_POS", [new IntParam(param0)]);
	public void DUNGEON_EXECUTE_PARTNER_POS() =>
		FlowLib.InvokeVoid("DUNGEON_EXECUTE_PARTNER_POS", []);
	public int DUNGEON_GET_AREA(int param0) =>
		FlowLib.InvokeInt("DUNGEON_GET_AREA", [new IntParam(param0)]);
	public int DUNGEON_GET_AREA_MINOR(int param0) =>
		FlowLib.InvokeInt("DUNGEON_GET_AREA_MINOR", [new IntParam(param0)]);
	public void FLD_FAM_SET_IMD_STOP(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_SET_IMD_STOP", [new IntParam(param0)]);
	public void FLD_CHARA_START_TURN(int param0, float param1, float param2, float param3, float param4) =>
		FlowLib.InvokeVoid("FLD_CHARA_START_TURN", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4)]);
	public void FLD_CHARA_SYNC_TURN() =>
		FlowLib.InvokeVoid("FLD_CHARA_SYNC_TURN", []);
	public void FLD_FAM_END_ANIM(int param0) =>
		FlowLib.InvokeVoid("FLD_FAM_END_ANIM", [new IntParam(param0)]);
	public void FLD_MODEL_DIR_TRANSLATE(int param0, float param1, float param2, int param3) =>
		FlowLib.InvokeVoid("FLD_MODEL_DIR_TRANSLATE", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new IntParam(param3)]);
	public void FLD_PC_MODEL_SET_LOCATION(float param0, float param1, float param2) =>
		FlowLib.InvokeVoid("FLD_PC_MODEL_SET_LOCATION", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2)]);
	public int DUNGEON_GET_TBOX_NUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_GET_TBOX_NUM", [new IntParam(param0)]);
	public void FLD_CHARA_MOVE_TO_FRONT_CHARA(int param0, int param1, float param2) =>
		FlowLib.InvokeVoid("FLD_CHARA_MOVE_TO_FRONT_CHARA", [new IntParam(param0), new IntParam(param1), new FloatParam(param2)]);
	public int FLD_CHK_HERO_HAVE_BAG() =>
		FlowLib.InvokeInt("FLD_CHK_HERO_HAVE_BAG", []);
	public void DUNGEON_EVENT_BATTLE_WIPE_START() =>
		FlowLib.InvokeVoid("DUNGEON_EVENT_BATTLE_WIPE_START", []);
	public int FLD_CHK_CAMERA_LOCK() =>
		FlowLib.InvokeInt("FLD_CHK_CAMERA_LOCK", []);
	public int DUNGEON_GET_MONAD_ENCOUNTID(int param0) =>
		FlowLib.InvokeInt("DUNGEON_GET_MONAD_ENCOUNTID", [new IntParam(param0)]);
	public int DUNGEON_FORCED_OPEN_TBOX(int param0) =>
		FlowLib.InvokeInt("DUNGEON_FORCED_OPEN_TBOX", [new IntParam(param0)]);
	public void DUNGEON_CLEAR_EVENT_TRANS_ORIGIN() =>
		FlowLib.InvokeVoid("DUNGEON_CLEAR_EVENT_TRANS_ORIGIN", []);
	public void DUNGEON_TBOXSE_STOP() =>
		FlowLib.InvokeVoid("DUNGEON_TBOXSE_STOP", []);
	public void FLD_SET_FIELD_EVENT_NO_WEAPON() =>
		FlowLib.InvokeVoid("FLD_SET_FIELD_EVENT_NO_WEAPON", []);
	public void DUNGEON_DESTROY_MISSING_NPC() =>
		FlowLib.InvokeVoid("DUNGEON_DESTROY_MISSING_NPC", []);
	public void DUNGEON_MISSING_SE_STOP() =>
		FlowLib.InvokeVoid("DUNGEON_MISSING_SE_STOP", []);
	public void FLD_CAMERA_LOCK_INTERP_RELATIVE(float param0, float param1, float param2, float param3, float param4, float param5, float param6) =>
		FlowLib.InvokeVoid("FLD_CAMERA_LOCK_INTERP_RELATIVE", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4), new FloatParam(param5), new FloatParam(param6)]);
	public void DUNGEON_SITUATION_HELP(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SITUATION_HELP", [new IntParam(param0)]);
	public void DUNGEON_SITUATION_HELP_ITEM(int param0, int param1) =>
		FlowLib.InvokeVoid("DUNGEON_SITUATION_HELP_ITEM", [new IntParam(param0), new IntParam(param1)]);
	public void DUNGEON_PARTNER_RELOAD() =>
		FlowLib.InvokeVoid("DUNGEON_PARTNER_RELOAD", []);
	public void FLD_HERO_MODEL_RELOAD() =>
		FlowLib.InvokeVoid("FLD_HERO_MODEL_RELOAD", []);
	public void FLD_OVERWRITE_CAMERA_PITCH(float param0) =>
		FlowLib.InvokeVoid("FLD_OVERWRITE_CAMERA_PITCH", [new FloatParam(param0)]);
	public void FLD_HERO_REGIST_PHONE_MODEL() =>
		FlowLib.InvokeVoid("FLD_HERO_REGIST_PHONE_MODEL", []);
	public void FLD_CAMERA_SHAKE_START(float param0, float param1, float param2, float param3) =>
		FlowLib.InvokeVoid("FLD_CAMERA_SHAKE_START", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3)]);
	public void FLD_CAMERA_SHAKE_END(float param0) =>
		FlowLib.InvokeVoid("FLD_CAMERA_SHAKE_END", [new FloatParam(param0)]);
	public void FLD_HERO_FUKIDASHI_START() =>
		FlowLib.InvokeVoid("FLD_HERO_FUKIDASHI_START", []);
	public void FLD_HERO_FUKIDASHI_END() =>
		FlowLib.InvokeVoid("FLD_HERO_FUKIDASHI_END", []);
	public void FLD_FREECAMERA_RESET() =>
		FlowLib.InvokeVoid("FLD_FREECAMERA_RESET", []);
	public void DUNGEON_SITUATION_HELP_MONEY(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SITUATION_HELP_MONEY", [new IntParam(param0)]);
	public int FLD_CAMERA_GET_DOT_HORIZON(float param0, float param1, float param2, float param3, float param4, float param5) =>
		FlowLib.InvokeInt("FLD_CAMERA_GET_DOT_HORIZON", [new FloatParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4), new FloatParam(param5)]);
	public void FLD_NPC_RELOAD(int param0) =>
		FlowLib.InvokeVoid("FLD_NPC_RELOAD", [new IntParam(param0)]);
	public void DUNGEON_SECRETGATE_SPAWN() =>
		FlowLib.InvokeVoid("DUNGEON_SECRETGATE_SPAWN", []);
	public void DUNGEON_TALK_SETDELAY(float param0) =>
		FlowLib.InvokeVoid("DUNGEON_TALK_SETDELAY", [new FloatParam(param0)]);
	public int DUNGEON_TALK_WAITDELAY() =>
		FlowLib.InvokeInt("DUNGEON_TALK_WAITDELAY", []);
	public void DUNGEON_CHARACOSTUME_RELOAD() =>
		FlowLib.InvokeVoid("DUNGEON_CHARACOSTUME_RELOAD", []);
	public void DUNGEON_SEPARATELEY_REQUEST(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_SEPARATELEY_REQUEST", [new IntParam(param0)]);
	public int DUNGEON_SEPARATELEY_GETITEMTYPENUM() =>
		FlowLib.InvokeInt("DUNGEON_SEPARATELEY_GETITEMTYPENUM", []);
	public int DUNGEON_SEPARATELEY_GETITEMID(int param0) =>
		FlowLib.InvokeInt("DUNGEON_SEPARATELEY_GETITEMID", [new IntParam(param0)]);
	public int DUNGEON_SEPARATELEY_GETITENUM(int param0) =>
		FlowLib.InvokeInt("DUNGEON_SEPARATELEY_GETITENUM", [new IntParam(param0)]);
	public void DUNGEON_SEPARATELEY_PARTYIN() =>
		FlowLib.InvokeVoid("DUNGEON_SEPARATELEY_PARTYIN", []);
	public void FLD_FOLLOWER_MODEL_RESET_POS() =>
		FlowLib.InvokeVoid("FLD_FOLLOWER_MODEL_RESET_POS", []);
	public void FLD_CHARA_SET_LOOKAT_ROTATION(int param0, float param1, float param2, float param3) =>
		FlowLib.InvokeVoid("FLD_CHARA_SET_LOOKAT_ROTATION", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3)]);
	public void FLD_CHARA_CLEAR_LOOKAT(int param0, float param1) =>
		FlowLib.InvokeVoid("FLD_CHARA_CLEAR_LOOKAT", [new IntParam(param0), new FloatParam(param1)]);
	public void FLD_NPC_PAUSE_IDOL_TALK(int param0) =>
		FlowLib.InvokeVoid("FLD_NPC_PAUSE_IDOL_TALK", [new IntParam(param0)]);
	public void FLD_NPC_RESTART_IDOL_TALK(int param0) =>
		FlowLib.InvokeVoid("FLD_NPC_RESTART_IDOL_TALK", [new IntParam(param0)]);
	public void FLD_CHARA_SET_LOOKAT_TARGET(int param0, float param1, float param2, float param3, float param4) =>
		FlowLib.InvokeVoid("FLD_CHARA_SET_LOOKAT_TARGET", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4)]);
	public int DUNGEON_GET_PARTNUM() =>
		FlowLib.InvokeInt("DUNGEON_GET_PARTNUM", []);
	public void DUNGEON_RESET_CHARA_BEHAVIOR() =>
		FlowLib.InvokeVoid("DUNGEON_RESET_CHARA_BEHAVIOR", []);
	public void DUNGEON_ENEMY_DIE(float param0, int param1) =>
		FlowLib.InvokeVoid("DUNGEON_ENEMY_DIE", [new FloatParam(param0), new IntParam(param1)]);
	public void FLD_MOVE_FLOOR_DAILY(int param0) =>
		FlowLib.InvokeVoid("FLD_MOVE_FLOOR_DAILY", [new IntParam(param0)]);
	public void DUNGEON_GET_TBOX_ITEM_SET_COUNTER(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_GET_TBOX_ITEM_SET_COUNTER", [new IntParam(param0)]);
	public void FLD_FAM_MODEL_LOOKAT_ROTATION(int param0, float param1, float param2, float param3) =>
		FlowLib.InvokeVoid("FLD_FAM_MODEL_LOOKAT_ROTATION", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3)]);
	public void FLD_FAM_MODEL_LOOKAT_TARGET(int param0, float param1, float param2, float param3, float param4) =>
		FlowLib.InvokeVoid("FLD_FAM_MODEL_LOOKAT_TARGET", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3), new FloatParam(param4)]);
	public void FLD_FAM_MODEL_CLEAR_LOOKAT(int param0, float param1) =>
		FlowLib.InvokeVoid("FLD_FAM_MODEL_CLEAR_LOOKAT", [new IntParam(param0), new FloatParam(param1)]);
	public void DUNGEON_ENEMY_DIE_EFFECT(int param0) =>
		FlowLib.InvokeVoid("DUNGEON_ENEMY_DIE_EFFECT", [new IntParam(param0)]);
	public void FLD_SOUND_POST_VOLUME_SET_LOCK() =>
		FlowLib.InvokeVoid("FLD_SOUND_POST_VOLUME_SET_LOCK", []);
	public void FLD_SOUND_POST_VOLUME_CLEAR_LOCK() =>
		FlowLib.InvokeVoid("FLD_SOUND_POST_VOLUME_CLEAR_LOCK", []);
	public void FLD_CHARA_START_TURN_TO_NPC(int param0, float param1, int param2) =>
		FlowLib.InvokeVoid("FLD_CHARA_START_TURN_TO_NPC", [new IntParam(param0), new FloatParam(param1), new IntParam(param2)]);
	public void FLD_MODEL_START_TURN_TO_MODEL(int param0, float param1, int param2) =>
		FlowLib.InvokeVoid("FLD_MODEL_START_TURN_TO_MODEL", [new IntParam(param0), new FloatParam(param1), new IntParam(param2)]);
	public int FLD_CHECK_INIT_AFTER_LOAD_SAVEDATA() =>
		FlowLib.InvokeInt("FLD_CHECK_INIT_AFTER_LOAD_SAVEDATA", []);
	public void FLD_REQ_ALL_LINK_ANIM_OBJ_END_MOTION() =>
		FlowLib.InvokeVoid("FLD_REQ_ALL_LINK_ANIM_OBJ_END_MOTION", []);
	public void FLD_RECREATE_MODEL_HEAD_ICON(int param0) =>
		FlowLib.InvokeVoid("FLD_RECREATE_MODEL_HEAD_ICON", [new IntParam(param0)]);
	public void FLD_REQ_TURN_DOWN_VOLUME() =>
		FlowLib.InvokeVoid("FLD_REQ_TURN_DOWN_VOLUME", []);
	public void FLD_RESET_TURN_DOWN_VOLUME() =>
		FlowLib.InvokeVoid("FLD_RESET_TURN_DOWN_VOLUME", []);
	public void FLD_SYNC_TURN_DOWN_VOLUME() =>
		FlowLib.InvokeVoid("FLD_SYNC_TURN_DOWN_VOLUME", []);
	public void FLD_RESET_HERO_OPACITY() =>
		FlowLib.InvokeVoid("FLD_RESET_HERO_OPACITY", []);
	public void FLD_REQ_ALL_LINK_ANIM_OBJ_MOTION_FORCE() =>
		FlowLib.InvokeVoid("FLD_REQ_ALL_LINK_ANIM_OBJ_MOTION_FORCE", []);
	public void DUNGEON_RESET_CHARA_QUICK() =>
		FlowLib.InvokeVoid("DUNGEON_RESET_CHARA_QUICK", []);
	public void FLD_SOUND_AISAC_CTRL_FORCE_LOCK() =>
		FlowLib.InvokeVoid("FLD_SOUND_AISAC_CTRL_FORCE_LOCK", []);
	public void FLD_SOUND_AISAC_CTRL_FORCE_UNLOCK() =>
		FlowLib.InvokeVoid("FLD_SOUND_AISAC_CTRL_FORCE_UNLOCK", []);
	public int FLD_FAM_OBJ_GET_NOW_ANIM_INDEX(int param0) =>
		FlowLib.InvokeInt("FLD_FAM_OBJ_GET_NOW_ANIM_INDEX", [new IntParam(param0)]);
	public void FLD_SAVE_ASTREA_LAST_BOSS_ROLLBACK_DATA() =>
		FlowLib.InvokeVoid("FLD_SAVE_ASTREA_LAST_BOSS_ROLLBACK_DATA", []);
	public void FLD_FADE_OUT_DUNGEON_FILTER() =>
		FlowLib.InvokeVoid("FLD_FADE_OUT_DUNGEON_FILTER", []);
	public void WAIT_DUNGEON_SUPPORT_SKILL() =>
		FlowLib.InvokeVoid("WAIT_DUNGEON_SUPPORT_SKILL", []);
	public int CMM_GET_LV(int param0) =>
		FlowLib.InvokeInt("CMM_GET_LV", [new IntParam(param0)]);
	public void CMM_SET_LV(int param0, int param1) =>
		FlowLib.InvokeVoid("CMM_SET_LV", [new IntParam(param0), new IntParam(param1)]);
	public void CMM_LVUP(int param0) =>
		FlowLib.InvokeVoid("CMM_LVUP", [new IntParam(param0)]);
	public int CMM_CHK_LVUP(int param0) =>
		FlowLib.InvokeInt("CMM_CHK_LVUP", [new IntParam(param0)]);
	public void CMM_EXEC_EVENT(int param0) =>
		FlowLib.InvokeVoid("CMM_EXEC_EVENT", [new IntParam(param0)]);
	public void CMM_SET_REVERSE_POINT(int param0, int param1) =>
		FlowLib.InvokeVoid("CMM_SET_REVERSE_POINT", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_CHK_ARCANA_PSSTOCK(int param0) =>
		FlowLib.InvokeInt("CMM_CHK_ARCANA_PSSTOCK", [new IntParam(param0)]);
	public void CMM_CALL_CONF_COMMUNITY(int param0, int param1) =>
		FlowLib.InvokeVoid("CMM_CALL_CONF_COMMUNITY", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_CHECK_HERO_PARAM_LOCK(int param0) =>
		FlowLib.InvokeInt("CMM_CHECK_HERO_PARAM_LOCK", [new IntParam(param0)]);
	public int GET_HERO_PARAM_LV(int param0) =>
		FlowLib.InvokeInt("GET_HERO_PARAM_LV", [new IntParam(param0)]);
	public void DISP_HERO_PARAM_METER() =>
		FlowLib.InvokeVoid("DISP_HERO_PARAM_METER", []);
	public void DISP_HERO_PARAM_RANK_UP() =>
		FlowLib.InvokeVoid("DISP_HERO_PARAM_RANK_UP", []);
	public void ADD_HERO_PARAM_EXP(int param0, int param1) =>
		FlowLib.InvokeVoid("ADD_HERO_PARAM_EXP", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_GET_REVERSE_POINT(int param0) =>
		FlowLib.InvokeInt("CMM_GET_REVERSE_POINT", [new IntParam(param0)]);
	public int GET_STOCK_PERSONA_ID(int param0) =>
		FlowLib.InvokeInt("GET_STOCK_PERSONA_ID", [new IntParam(param0)]);
	public int CMM_PC_NAME(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("CMM_PC_NAME", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int CMM_NAME(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_NAME", [new IntParam(param0), new IntParam(param1)]);
	public void HERO_PARAM_ALL_ADD_EXP(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("HERO_PARAM_ALL_ADD_EXP", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void CMM_ADD_ID(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CMM_ADD_ID", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int CMM_CHECK_HOLIDAY_EVENT(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_CHECK_HOLIDAY_EVENT", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_HOLIDAY_EVENT_GET_ARCANAID(int param0, int param1, int param2) =>
		FlowLib.InvokeInt("CMM_HOLIDAY_EVENT_GET_ARCANAID", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void CMM_CALL_EVENT_SET_ARCANAID(int param0) =>
		FlowLib.InvokeVoid("CMM_CALL_EVENT_SET_ARCANAID", [new IntParam(param0)]);
	public void CMM_EXEC_HOLIDAY_EVENT() =>
		FlowLib.InvokeVoid("CMM_EXEC_HOLIDAY_EVENT", []);
	public int CMM_GET_PRESENT_REACTION_MESSAGE_LABEL(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_GET_PRESENT_REACTION_MESSAGE_LABEL", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_GET_PRESENT_HERO_MESSAGE_LABEL(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_GET_PRESENT_HERO_MESSAGE_LABEL", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_GET_PRESENT_POINT(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_GET_PRESENT_POINT", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_CHECK_SUMMER_FESTIVAL_EVENT(int param0) =>
		FlowLib.InvokeInt("CMM_CHECK_SUMMER_FESTIVAL_EVENT", [new IntParam(param0)]);
	public int CMM_GET_SUMMER_FESTIVAL_EVENT_MAILID(int param0) =>
		FlowLib.InvokeInt("CMM_GET_SUMMER_FESTIVAL_EVENT_MAILID", [new IntParam(param0)]);
	public void CMM_EXEC_SUMMER_FESTIVAL_EVENT() =>
		FlowLib.InvokeVoid("CMM_EXEC_SUMMER_FESTIVAL_EVENT", []);
	public int CMM_CHECK_MOVIES_EVENT(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_CHECK_MOVIES_EVENT", [new IntParam(param0), new IntParam(param1)]);
	public int CMM_GET_MOVIES_EVENT_MAILID(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_GET_MOVIES_EVENT_MAILID", [new IntParam(param0), new IntParam(param1)]);
	public void CMM_EXEC_MOVIES_EVENT() =>
		FlowLib.InvokeVoid("CMM_EXEC_MOVIES_EVENT", []);
	public int CMM_CHECK_CHRISTMAS_EVENT(int param0) =>
		FlowLib.InvokeInt("CMM_CHECK_CHRISTMAS_EVENT", [new IntParam(param0)]);
	public int CMM_GET_CHRISTMAS_EVENT_MAILID(int param0) =>
		FlowLib.InvokeInt("CMM_GET_CHRISTMAS_EVENT_MAILID", [new IntParam(param0)]);
	public void CMM_EXEC_CHRISTMAS_EVENT() =>
		FlowLib.InvokeVoid("CMM_EXEC_CHRISTMAS_EVENT", []);
	public void CMM_SET_PC_NAME_V(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CMM_SET_PC_NAME_V", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public int CMM_GET_PRESENT_CHRISTMAS_REACTION_MESSAGE_LABEL(int param0, int param1) =>
		FlowLib.InvokeInt("CMM_GET_PRESENT_CHRISTMAS_REACTION_MESSAGE_LABEL", [new IntParam(param0), new IntParam(param1)]);
	public void CALL_EVENT(int param0, int param1) =>
		FlowLib.InvokeVoid("CALL_EVENT", [new IntParam(param0), new IntParam(param1)]);
	public void CALL_EVENT_CMM(int param0, int param1) =>
		FlowLib.InvokeVoid("CALL_EVENT_CMM", [new IntParam(param0), new IntParam(param1)]);
	public void CUTIN_START(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CUTIN_START", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void CUTIN_STOP() =>
		FlowLib.InvokeVoid("CUTIN_STOP", []);
	public void EVT_SET_LOCAL_COUNT(int param0, int param1) =>
		FlowLib.InvokeVoid("EVT_SET_LOCAL_COUNT", [new IntParam(param0), new IntParam(param1)]);
	public int EVT_GET_LOCAL_COUNT(int param0) =>
		FlowLib.InvokeInt("EVT_GET_LOCAL_COUNT", [new IntParam(param0)]);
	public void EVT_SET_LOCAL_DATA(int param0, int param1) =>
		FlowLib.InvokeVoid("EVT_SET_LOCAL_DATA", [new IntParam(param0), new IntParam(param1)]);
	public int EVT_GET_LOCAL_DATA(int param0) =>
		FlowLib.InvokeInt("EVT_GET_LOCAL_DATA", [new IntParam(param0)]);
	public void CUTIN_START_EX(int param0, int param1, int param2, int param3, int param4, int param5) =>
		FlowLib.InvokeVoid("CUTIN_START_EX", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4), new IntParam(param5)]);
	public void BACKLOG_ADD_INVALID_ON() =>
		FlowLib.InvokeVoid("BACKLOG_ADD_INVALID_ON", []);
	public void BACKLOG_ADD_INVALID_OFF() =>
		FlowLib.InvokeVoid("BACKLOG_ADD_INVALID_OFF", []);
	public void NET_START_ANSWER() =>
		FlowLib.InvokeVoid("NET_START_ANSWER", []);
	public void NET_END_ANSWER() =>
		FlowLib.InvokeVoid("NET_END_ANSWER", []);
	public void EVT_ASSET_OVERWRITE(int param0, int param1, string param2, int param3, int param4) =>
		FlowLib.InvokeVoid("EVT_ASSET_OVERWRITE", [new IntParam(param0), new IntParam(param1), new StringParam(param2), new IntParam(param3), new IntParam(param4)]);
	public void EVT_SE_PLAY(int param0, int param1) =>
		FlowLib.InvokeVoid("EVT_SE_PLAY", [new IntParam(param0), new IntParam(param1)]);
	public void EVT_SE_STOP(int param0, int param1) =>
		FlowLib.InvokeVoid("EVT_SE_STOP", [new IntParam(param0), new IntParam(param1)]);
	public void EVT_SEND_ANSWER_SELINFO(int param0) =>
		FlowLib.InvokeVoid("EVT_SEND_ANSWER_SELINFO", [new IntParam(param0)]);
	public void EVT_ATTACH_BAG() =>
		FlowLib.InvokeVoid("EVT_ATTACH_BAG", []);
	public void EVT_DESTROY_BAG() =>
		FlowLib.InvokeVoid("EVT_DESTROY_BAG", []);
	public void EVT_PUSH_TEXTURE_TO_LOAD(int param0) =>
		FlowLib.InvokeVoid("EVT_PUSH_TEXTURE_TO_LOAD", [new IntParam(param0)]);
	public void EVT_START_LODING_TEXTURE() =>
		FlowLib.InvokeVoid("EVT_START_LODING_TEXTURE", []);
	public void EVT_LOAD_TEXTURE_SYNC() =>
		FlowLib.InvokeVoid("EVT_LOAD_TEXTURE_SYNC", []);
	public void EVT_SHOW_TEXTURE(int param0, float param1, float param2, float param3) =>
		FlowLib.InvokeVoid("EVT_SHOW_TEXTURE", [new IntParam(param0), new FloatParam(param1), new FloatParam(param2), new FloatParam(param3)]);
	public void EVT_HIDE_TEXTURE() =>
		FlowLib.InvokeVoid("EVT_HIDE_TEXTURE", []);
	public void EVT_CALL_BATTLE_WIPE() =>
		FlowLib.InvokeVoid("EVT_CALL_BATTLE_WIPE", []);
	public void EVT_SHOW_TEXTURE_DEFAULT(int param0) =>
		FlowLib.InvokeVoid("EVT_SHOW_TEXTURE_DEFAULT", [new IntParam(param0)]);
	public void EVT_ENABLE_SKIP_BC() =>
		FlowLib.InvokeVoid("EVT_ENABLE_SKIP_BC", []);
	public void EVT_GAMEOVER_POEM() =>
		FlowLib.InvokeVoid("EVT_GAMEOVER_POEM", []);
	public void EVT_HIDE_CHARACTER(int param0) =>
		FlowLib.InvokeVoid("EVT_HIDE_CHARACTER", [new IntParam(param0)]);
	public int EVT_GET_FADE_COLOR() =>
		FlowLib.InvokeInt("EVT_GET_FADE_COLOR", []);
	public void EVT_FCL_VOICE_STOP(int param0) =>
		FlowLib.InvokeVoid("EVT_FCL_VOICE_STOP", [new IntParam(param0)]);
	public void CALL_WEAPON_SHOP_LV() =>
		FlowLib.InvokeVoid("CALL_WEAPON_SHOP_LV", []);
	public void CALL_ITEM_SHOP_LV() =>
		FlowLib.InvokeVoid("CALL_ITEM_SHOP_LV", []);
	public void CALL_VELVET_ROOM_LV() =>
		FlowLib.InvokeVoid("CALL_VELVET_ROOM_LV", []);
	public void CALL_PUBLIC_SHOP(int param0) =>
		FlowLib.InvokeVoid("CALL_PUBLIC_SHOP", [new IntParam(param0)]);
	public void CALL_ANTIQUE_SHOP_LV() =>
		FlowLib.InvokeVoid("CALL_ANTIQUE_SHOP_LV", []);
	public void UI_DUMMY4() =>
		FlowLib.InvokeVoid("UI_DUMMY4", []);
	public void UI_DUMMY5() =>
		FlowLib.InvokeVoid("UI_DUMMY5", []);
	public void UI_DUMMY6() =>
		FlowLib.InvokeVoid("UI_DUMMY6", []);
	public void UI_DUMMY7() =>
		FlowLib.InvokeVoid("UI_DUMMY7", []);
	public void UI_DUMMY8() =>
		FlowLib.InvokeVoid("UI_DUMMY8", []);
	public void UI_DUMMY9() =>
		FlowLib.InvokeVoid("UI_DUMMY9", []);
	public void UI_DUMMY10() =>
		FlowLib.InvokeVoid("UI_DUMMY10", []);
	public void UI_DUMMY11() =>
		FlowLib.InvokeVoid("UI_DUMMY11", []);
	public void UI_DUMMY12() =>
		FlowLib.InvokeVoid("UI_DUMMY12", []);
	public void UI_DUMMY13() =>
		FlowLib.InvokeVoid("UI_DUMMY13", []);
	public void UI_DUMMY14() =>
		FlowLib.InvokeVoid("UI_DUMMY14", []);
	public void CALL_MONEY_PANEL() =>
		FlowLib.InvokeVoid("CALL_MONEY_PANEL", []);
	public void CLOSE_MONEY_PANEL() =>
		FlowLib.InvokeVoid("CLOSE_MONEY_PANEL", []);
	public void CALL_ADD_MONEY(int param0) =>
		FlowLib.InvokeVoid("CALL_ADD_MONEY", [new IntParam(param0)]);
	public void CINEMASCOPE_START() =>
		FlowLib.InvokeVoid("CINEMASCOPE_START", []);
	public void CINEMASCOPE_END() =>
		FlowLib.InvokeVoid("CINEMASCOPE_END", []);
	public void ADD_GET_ITEM_LIST(int param0, int param1) =>
		FlowLib.InvokeVoid("ADD_GET_ITEM_LIST", [new IntParam(param0), new IntParam(param1)]);
	public void OPEN_GET_ITEM() =>
		FlowLib.InvokeVoid("OPEN_GET_ITEM", []);
	public void RESET_GET_ITEM_LIST() =>
		FlowLib.InvokeVoid("RESET_GET_ITEM_LIST", []);
	public int GET_ITEM_NUM(int param0) =>
		FlowLib.InvokeInt("GET_ITEM_NUM", [new IntParam(param0)]);
	public void SET_ITEM_NUM(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_ITEM_NUM", [new IntParam(param0), new IntParam(param1)]);
	public int CALL_LMAP(int param0) =>
		FlowLib.InvokeInt("CALL_LMAP", [new IntParam(param0)]);
	public void CLOSE_LMAP() =>
		FlowLib.InvokeVoid("CLOSE_LMAP", []);
	public void CMM_RANKUP(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("CMM_RANKUP", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void ADD_GET_ITEM_LIST_MONEY(int param0) =>
		FlowLib.InvokeVoid("ADD_GET_ITEM_LIST_MONEY", [new IntParam(param0)]);
	public void OPEN_SUPPORT_PARTY_PANEL() =>
		FlowLib.InvokeVoid("OPEN_SUPPORT_PARTY_PANEL", []);
	public void CLOSE_SUPPORT_PARTY_PANEL() =>
		FlowLib.InvokeVoid("CLOSE_SUPPORT_PARTY_PANEL", []);
	public void FAKE_DATE_SET(int param0, int param1, int param2) =>
		FlowLib.InvokeVoid("FAKE_DATE_SET", [new IntParam(param0), new IntParam(param1), new IntParam(param2)]);
	public void FAKE_DATE_RESET() =>
		FlowLib.InvokeVoid("FAKE_DATE_RESET", []);
	public void CHANGE_MINIMAP() =>
		FlowLib.InvokeVoid("CHANGE_MINIMAP", []);
	public void OPEN_MAIL_MENU() =>
		FlowLib.InvokeVoid("OPEN_MAIL_MENU", []);
	public void CLOSE_MAIL_MENU() =>
		FlowLib.InvokeVoid("CLOSE_MAIL_MENU", []);
	public int RECEIVE_MAIL_CONDITIONAL() =>
		FlowLib.InvokeInt("RECEIVE_MAIL_CONDITIONAL", []);
	public int RECEIVE_MAIL_FORCIBLY(int param0) =>
		FlowLib.InvokeInt("RECEIVE_MAIL_FORCIBLY", [new IntParam(param0)]);
	public void RESET_MAIL_BOX() =>
		FlowLib.InvokeVoid("RESET_MAIL_BOX", []);
	public int GET_SAVED_DISAPPEAR_ID() =>
		FlowLib.InvokeInt("GET_SAVED_DISAPPEAR_ID", []);
	public void GET_DISAPPEAR_AWARD(int param0) =>
		FlowLib.InvokeVoid("GET_DISAPPEAR_AWARD", [new IntParam(param0)]);
	public void MASTERY_THEURGIA_DRAW(int param0) =>
		FlowLib.InvokeVoid("MASTERY_THEURGIA_DRAW", [new IntParam(param0)]);
	public int DUNGEON_LMAP_OPEN() =>
		FlowLib.InvokeInt("DUNGEON_LMAP_OPEN", []);
	public void SET_HIDE_MINIMAP(int param0) =>
		FlowLib.InvokeVoid("SET_HIDE_MINIMAP", [new IntParam(param0)]);
	public void SET_MONAD_MINIMAP(int param0) =>
		FlowLib.InvokeVoid("SET_MONAD_MINIMAP", [new IntParam(param0)]);
	public int GET_RECEIVED_MAIL_NUM() =>
		FlowLib.InvokeInt("GET_RECEIVED_MAIL_NUM", []);
	public void CINEMASCOPE_START_ANIME() =>
		FlowLib.InvokeVoid("CINEMASCOPE_START_ANIME", []);
	public void CINEMASCOPE_END_ANIME() =>
		FlowLib.InvokeVoid("CINEMASCOPE_END_ANIME", []);
	public void CALL_DISAPPEAR_LIST() =>
		FlowLib.InvokeVoid("CALL_DISAPPEAR_LIST", []);
	public void SET_ACTION_RECORD(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_ACTION_RECORD", [new IntParam(param0), new IntParam(param1)]);
	public void OPEN_PICTURE(int param0, int param1) =>
		FlowLib.InvokeVoid("OPEN_PICTURE", [new IntParam(param0), new IntParam(param1)]);
	public void CLOSE_PICTURE() =>
		FlowLib.InvokeVoid("CLOSE_PICTURE", []);
	public void CALL_CAMP_CALENDAR() =>
		FlowLib.InvokeVoid("CALL_CAMP_CALENDAR", []);
	public void CALL_NAME_ENTRY() =>
		FlowLib.InvokeVoid("CALL_NAME_ENTRY", []);
	public void OPEN_MAIL_MENU_WITH_SET_ID(int param0, int param1) =>
		FlowLib.InvokeVoid("OPEN_MAIL_MENU_WITH_SET_ID", [new IntParam(param0), new IntParam(param1)]);
	public int FRIEND_SKILL_ADD(int param0) =>
		FlowLib.InvokeInt("FRIEND_SKILL_ADD", [new IntParam(param0)]);
	public int CHK_FRIEND_SKILL_ADD(int param0) =>
		FlowLib.InvokeInt("CHK_FRIEND_SKILL_ADD", [new IntParam(param0)]);
	public void SET_ADD_MONEY_PLANS(int param0) =>
		FlowLib.InvokeVoid("SET_ADD_MONEY_PLANS", [new IntParam(param0)]);
	public void SET_VELVET_VTAG(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_VELVET_VTAG", [new IntParam(param0), new IntParam(param1)]);
	public void CALL_ADD_MONEY_AUTO_CLOSE(int param0) =>
		FlowLib.InvokeVoid("CALL_ADD_MONEY_AUTO_CLOSE", [new IntParam(param0)]);
	public void MONEY_PANEL_COLOR_CHANGE(int param0) =>
		FlowLib.InvokeVoid("MONEY_PANEL_COLOR_CHANGE", [new IntParam(param0)]);
	public void CALL_VELVET_REQUEST() =>
		FlowLib.InvokeVoid("CALL_VELVET_REQUEST", []);
	public int GET_ORDERED_REQUEST_ID() =>
		FlowLib.InvokeInt("GET_ORDERED_REQUEST_ID", []);
	public void ADD_REQUEST_ITEM_AND_CLEAR_FLAG_ON(int param0) =>
		FlowLib.InvokeVoid("ADD_REQUEST_ITEM_AND_CLEAR_FLAG_ON", [new IntParam(param0)]);
	public int GET_ORDERED_REQUEST_TOTAL() =>
		FlowLib.InvokeInt("GET_ORDERED_REQUEST_TOTAL", []);
	public void LIMIT_DISP(int param0, int param1) =>
		FlowLib.InvokeVoid("LIMIT_DISP", [new IntParam(param0), new IntParam(param1)]);
	public int GET_CANCEL_REQUEST_TOTAL() =>
		FlowLib.InvokeInt("GET_CANCEL_REQUEST_TOTAL", []);
	public int GET_HAVE_PERSONA(int param0) =>
		FlowLib.InvokeInt("GET_HAVE_PERSONA", [new IntParam(param0)]);
	public int GET_HAVE_PERSONA_LV(int param0) =>
		FlowLib.InvokeInt("GET_HAVE_PERSONA_LV", [new IntParam(param0)]);
	public void TROPHY_REQUEST(string param0, float param1) =>
		FlowLib.InvokeVoid("TROPHY_REQUEST", [new StringParam(param0), new FloatParam(param1)]);
	public void ORDER_QUEST(int param0) =>
		FlowLib.InvokeVoid("ORDER_QUEST", [new IntParam(param0)]);
	public void QUEST_LIST_ALL_INFO_DISPLAY() =>
		FlowLib.InvokeVoid("QUEST_LIST_ALL_INFO_DISPLAY", []);
	public void GET_ADC_ITEM_WINDOW() =>
		FlowLib.InvokeVoid("GET_ADC_ITEM_WINDOW", []);
	public int CHECK_ADC_ITEM_VALID() =>
		FlowLib.InvokeInt("CHECK_ADC_ITEM_VALID", []);
	public int CHECK_NEW_QUEST_EXIST() =>
		FlowLib.InvokeInt("CHECK_NEW_QUEST_EXIST", []);
	public int GET_PERSONA_REGIST_PERCENT() =>
		FlowLib.InvokeInt("GET_PERSONA_REGIST_PERCENT", []);
	public void CMM_POINT_ANIM_SYNC() =>
		FlowLib.InvokeVoid("CMM_POINT_ANIM_SYNC", []);
	public void SET_ITEM_NUM_EX(int param0, int param1) =>
		FlowLib.InvokeVoid("SET_ITEM_NUM_EX", [new IntParam(param0), new IntParam(param1)]);
	public int CHECK_DATA_INHERITANCE() =>
		FlowLib.InvokeInt("CHECK_DATA_INHERITANCE", []);
	public void GET_THEURGIA_SKILL_ADD_DRAW_LIST(int param0) =>
		FlowLib.InvokeVoid("GET_THEURGIA_SKILL_ADD_DRAW_LIST", [new IntParam(param0)]);
	public void GET_THEURGIA_SKILL_DRAW(int param0) =>
		FlowLib.InvokeVoid("GET_THEURGIA_SKILL_DRAW", [new IntParam(param0)]);
	public int GET_ORDERED_REQUEST_ID_SELECT(int param0) =>
		FlowLib.InvokeInt("GET_ORDERED_REQUEST_ID_SELECT", [new IntParam(param0)]);
	public int GET_REQUEST_STATUS(int param0) =>
		FlowLib.InvokeInt("GET_REQUEST_STATUS", [new IntParam(param0)]);
	public int CALL_CLEAR_SAVE() =>
		FlowLib.InvokeInt("CALL_CLEAR_SAVE", []);
	public void LOAD_STAFFROLL(int param0) =>
		FlowLib.InvokeVoid("LOAD_STAFFROLL", [new IntParam(param0)]);
	public void CALL_STAFFROLL() =>
		FlowLib.InvokeVoid("CALL_STAFFROLL", []);
	public void GET_ADC_ITEM_WINDOW_SYNC() =>
		FlowLib.InvokeVoid("GET_ADC_ITEM_WINDOW_SYNC", []);
	public void IN_NAMEENTRY() =>
		FlowLib.InvokeVoid("IN_NAMEENTRY", []);
	public void OUT_NAMEENTRY() =>
		FlowLib.InvokeVoid("OUT_NAMEENTRY", []);
	public void RECOVERY_EFFECT_FIELD_PARTY_PANEL() =>
		FlowLib.InvokeVoid("RECOVERY_EFFECT_FIELD_PARTY_PANEL", []);
	public void VELVET_WIPE_WITH_FADE_FLAG_TRUE() =>
		FlowLib.InvokeVoid("VELVET_WIPE_WITH_FADE_FLAG_TRUE", []);
	public void RESET_FOOT_MINIMAP() =>
		FlowLib.InvokeVoid("RESET_FOOT_MINIMAP", []);
	public void UI_DUMMY_ASTREA1() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA1", []);
	public void UI_DUMMY_ASTREA2() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA2", []);
	public void UI_DUMMY_ASTREA3() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA3", []);
	public void UI_DUMMY_ASTREA4() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA4", []);
	public void UI_DUMMY_ASTREA5() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA5", []);
	public void UI_DUMMY_ASTREA6() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA6", []);
	public void UI_DUMMY_ASTREA7() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA7", []);
	public void UI_DUMMY_ASTREA8() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA8", []);
	public void UI_DUMMY_ASTREA9() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA9", []);
	public void UI_DUMMY_ASTREA10() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA10", []);
	public void UI_DUMMY_ASTREA11() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA11", []);
	public void UI_DUMMY_ASTREA12() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA12", []);
	public void UI_DUMMY_ASTREA13() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA13", []);
	public void UI_DUMMY_ASTREA14() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA14", []);
	public void UI_DUMMY_ASTREA15() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA15", []);
	public void UI_DUMMY_ASTREA16() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA16", []);
	public void UI_DUMMY_ASTREA17() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA17", []);
	public void UI_DUMMY_ASTREA18() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA18", []);
	public void UI_DUMMY_ASTREA19() =>
		FlowLib.InvokeVoid("UI_DUMMY_ASTREA19", []);
	public void FAKE_DATE_SET_UNKNOWN() =>
		FlowLib.InvokeVoid("FAKE_DATE_SET_UNKNOWN", []);
	public int GET_AVAILABLE_WEAPONSHOP_AWARD_ID() =>
		FlowLib.InvokeInt("GET_AVAILABLE_WEAPONSHOP_AWARD_ID", []);
	public void GET_WEAPONSHOP_AWARD(int param0) =>
		FlowLib.InvokeVoid("GET_WEAPONSHOP_AWARD", [new IntParam(param0)]);
	public void ADD_GET_ITEM_LIST_RAFFLESIYA(int param0, int param1, int param2, int param3, int param4) =>
		FlowLib.InvokeVoid("ADD_GET_ITEM_LIST_RAFFLESIYA", [new IntParam(param0), new IntParam(param1), new IntParam(param2), new IntParam(param3), new IntParam(param4)]);
	public int SQUARE(int param0) =>
		FlowLib.InvokeInt("SQUARE", [new IntParam(param0)]);
}