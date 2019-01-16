#pragma once
#include "serialex.h"

typedef struct tagTRGCTRL
{
	UINT Type				: 4;		//0:DIFF, 1:TTL, 2:Virtual Encoder
	UINT Ch					: 4;		//Encoder CH (0~3)
	UINT Multi				: 4;		//Encoder Multi(1:x1, 2:x2, 4:x4)
	UINT CondFactor			: 4;		//0:DI0 ~ 6:DI6, 7:High, 8:Low
	UINT OutputOperator		: 4;		//0:AND, 1:OR, 2:XOR, 3:NAND
	UINT DirectionFactor	: 4;		//0:DISABLE, 1:DI0 ~ 7:DI6, 8:CW, 9:CCW
	UINT PositionDirection	: 4;		//0:DISABLE, 1:Positive, 2:Negative, 3:Bi-Direction
	UINT Temp				: 2;
	UINT Correction			: 1;		//0:DISABLE, 1:ENABLE
	UINT TriggerBase		: 1;		//0:COUNT, 1:POSITION
} TRGCTRL;


enum {
	BOARD_CH_TYPE_852,
	BOARD_CH_TYPE_100D,
	BOARD_CH_TYPE_100A,
	BOARD_CH_TYPE_ROLL,
};
//////////////////////////////////////////////////////////////////////////
/*	
Ex)

	xxEnc852Serial m_serial;
	m_serial.Open("COM1");

	if (m_serial.IsValid())
	{
		//트리거보드 연결안됨.
		return;
	}

	//FirmwareVersion (3.00)
	double firwareVersion = m_serial.GetFirmwareVersion();

	//Resolution 80um
	m_serial.SetEncoderResolution(80);

	m_serial.Purge();
	m_serial.Close();

*/
#define WM_SIGNAL_COMPLETED (WM_USER+1)
#define WM_SIGNAL_DATA		(WM_USER+2)
#define WM_SIGNAL_STEP		(WM_USER+3)

typedef struct  
{
	byte *dataA;
	byte *dataB;
	byte *dataC;
} SIGNALDATA, *PSIGNALDATA;


class xxEnc852Serial :
	public CSerialEx
{
public:
	xxEnc852Serial(void);
	~xxEnc852Serial(void);

	static EPort CheckPort (LPCTSTR lpszDevice);

	virtual LONG Open (LPCTSTR lpszDevice, DWORD dwInQueue = 0, DWORD dwOutQueue = 0, bool fStartListener = false);
	virtual LONG Purge();

	virtual void OnEvent( EEvent eEvent, EError eError );

	bool SendData(char command, USHORT address, UINT data, UINT *out = NULL);
	bool SendRead(USHORT address, UINT data = 0, UINT *out = NULL);
	bool SendWrite(USHORT address, UINT data = 1, UINT *out = NULL);

	bool IsValid();
	
	
	//트리거 설정
	//TRGCTRL 구조체 참고
	void SetTriggerControls(int triggerID, int type, int channel, int multi, int conditionFactor, int outputOperator, int directionFactor, int positionDirection, int correction, int triggerBase);
	void SetTriggerControls(int triggerID, const TRGCTRL& ctrl);
	void SetTriggerControls(int triggerID, UINT ctrl);
	int GetTriggerControls(int triggerID, TRGCTRL* ctrl);
	UINT GetTriggerControls(int triggerID);

	//트리거출력 설정
	//구형버전 사용, 호환성문제로 기존함수 같이 사용
	void SetTriggerGenerator(int triggerID, int cycle, int pulseHigh);
	void SetTriggerGenerator(int triggerID, UINT generator);
	int GetTriggerGenerator(int triggerID, int* cycle, int* pulseHigh);
	UINT GetTriggerGenerator(int triggerID);

	//ROLL VERSION 전용
	void SetTriggerGeneratorCycle(int triggerID, UINT cycle);
	UINT GetTriggerGeneratorCycle(int triggerID);

	//아날로그 채배율 설정
	void SetEncoderMultiForAnalog(int triggerID, int multi);
	int GetEncoderMultiForAnalog(int triggerID);

	//사용안함.
	void SetEncoderInputRange(int triggerID, int range);
	int GetEncoderInputRange(int triggerID);

	//아날로그 엔코더 전용 함수
	//A상과 B상을 바꿈.
	void SetEncoderInversion(int triggerID, int inversion);
	int GetEncoderInversion(int triggerID);

	//아날로그 엔코더 캘리브레이션
	void StartCalibration(int triggerID);
	void StopCalibration(int triggerID);

	//트리거 출력 구간 설정
	//count 값으로 설정
	void SetTriggerPosition0(int triggerID, int position);
	//um 값으로 설정
	int SetTriggerPosition0(int triggerID, int position, int multi, double resolution, int unit = 0);
	int GetTriggerPosition0(int triggerID);
	//count 값으로 설정
	void SetTriggerPosition1(int triggerID, int position);
	//um 값으로 설정
	int SetTriggerPosition1(int triggerID, int position, int multi, double resolution, int unit = 0);
	int GetTriggerPosition1(int triggerID);

	void SetEncoderDirection(int triggerID, int direction);
	int GetEncoderDirection(int triggerID);

	//트리거 출력 모드 설정
	void SetTriggerOutputMode(int triggerID, int mode);
	int GetTriggerOutputMode(int triggerID);

	void SetTriggerPulseWidth(int triggerID, double pulseWidth);
	double GetTriggerPulseWidth(int triggerID);

	void SetTriggerDelay(int triggerID, double delay);
	double GetTriggerDelay(int triggerID);

	void SetEncoderResetValue(int triggerID, int position);
	int GetEncoderResetValue(int triggerID);

	//가상 엔코더, 주파수 설정
	void SetVirtualEncoderFrequency(int virtualEncoderID, int frequency);
	int GetVirtualEncoderFrequency(int virtualEncoderID);


	//디지털입력 값 가져오기
	int GetDI(int* di0, int* di1, int* di2, int* di3, int* di4, int* di5, int* di6);
	int GetDIState(int diID);
	UINT GetDI();
	
	//디지털입력 카운트 값 가져오기
	UINT GetDiCount(int diID);
	//트리거출력 카운트 값 가져오기
	UINT GetTriggerCount(int triggerID);
	//현재위치 가져오기 count
	int GetEncoderPosition(int encoderID);
	//디지털 현재위치 가져오기 um
	int GetEncoderPosition(int encoderID, int multi, double resolution, int unit = 0);
	//100A 현재위치 가져오기 um
	int GetEncoderPositionForAnalog(int encoderID, int multi, double resolution, int unit = 0);
	//에러 카운트 값 가져오기
	UINT GetTriggerErrorCount(int triggerID);
	
	//펌웨어버전과 보드타입 가져오기
	double GetFirmwareVersion(int *boardType, int *boardChType);
	//로직버전 가져오기
	double GetLogicVersion();

	//보드초기화
	void LoadDefaultParameters();
	//플래시메모리에 설정값 저장
	void SaveFlash();
	//플래시메모리에서 설정값 가져오기
	void LoadFlash();
	//모든 카운트 초기화
	void ClearAll();
	//디지털입력 카운트 초기화
	void ClearDiAll();
	//트리거출력 카운트 초기화
	void ClearTriggerAll();
	//현재위치 초기화
	void ClearEncoderPositionAll();
	//에러 카운트 초기화
	void ClearErrorCountAll();
	//디지털입력 카운트 초기화 개별
	void ClearDiCount(int diID);
	//트리거출력 카운트 초기화 개별
	void ClearTriggerCount(int triggerID);
	//현재위치 초기화 개별
	void ClearEncoderPosition(int encoderID);
	//에러 카운트 초기화 개별
	void ClearErrorCount(int id);

	//스코프 전용 사용안함.
	void StartScope();
	void StopScope();
	
	void SetStartSignal(int signal);
	int GetStartSignal();
	void SetEncoderCh(int ch);
	int GetEncoderCh();
	void SetSamplingClock(int clock);
	int GetSamplingClock();


	bool GetScopeData(byte* dataA, byte* dataB, byte* dataC, bool *stopping = NULL);

	void SetStartPosition(int position);
	int GetStartPosition();


	
	//엔코더 분해능 설정
	//resolution (um)
	void SetEncoderResolution(double resolution);
	double GetEncoderResolution();

	//사용안함.
	void SetUnit(int unit);
	int GetUnit();
	
	
	
	//스코프 전용 자료제공안됨
	HWND m_hDlg;
	HANDLE m_hThreadScope;
	bool m_bScopeStopping;
	static DWORD WINAPI ThreadScope(LPVOID lpArg);
	DWORD ThreadScope (void);

	LONG StartScopeAsync(HWND hWnd);
	LONG StopScopeAsync();

	void SendMessageSignalData(PSIGNALDATA data);
	void SendMessageStep(int step);
	void SendMessageSignalCompleted();
};