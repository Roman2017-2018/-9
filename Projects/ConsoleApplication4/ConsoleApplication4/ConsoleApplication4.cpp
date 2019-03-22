// ConsoleApplication4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <Windows.h>

	template <typename T>
	class CVector {
	public:
		CVector() : _nDesired(0) {
			_pLast = _pFirst = _pBegin = new T[nMinimalSize];
			_pEnd = _pBegin + nMinimalSize;
			// init cs
			InitializeCriticalSection(&_csAccess);
			// init reach event
			_hEvReach = CreateEvent(0, FALSE, FALSE, 0);
		}
		~CVector() {
			delete[] _pBegin;
			// delete reach event
			CloseHandle(_hEvReach);
			// delete cs
			DeleteCriticalSection(&_csAccess);
		}
		void WaitForDuty() {
			EnterCriticalSection(&_csAccess);
		}
		void WaitForGtOrEq(int nDesired, bool bDuty = true) {
			WaitForDuty();
			if (size()<nDesired) {
				_nDesired = nDesired;
				LeaveDuty();
				WaitForSingleObject(_hEvReach, INFINITE);
				if (bDuty)
					WaitForDuty();
			}
			else if (!bDuty)
				LeaveDuty();
		}
		void SetDesired(int nDesired) {
			_nDesired = nDesired;
		}
		bool IsReachDesired() const {
			return WaitForSingleObject(_hEvReach, 0) == WAIT_OBJECT_0;
		}
		void LeaveDuty() {
			LeaveCriticalSection(&_csAccess);
		}
		T *begin() const {
			return _pFirst;
		}
		T *end() const {
			return _pLast;
		}
		int size() const {
			return _pLast - _pFirst;
		}
		bool empty() const {
			return size() == 0;
		}
		T &operator[](int nPos) {
			return *(_pFirst + nPos);
		}
		void back_insert(const T *pF, const T *pL) {
			if (pL - pF <= _pEnd - _pLast) {
			}
			else if (_pLast - _pFirst + pL - pF <= _pEnd - _pBegin) {
				MoveMemory(_pBegin, _pFirst, (_pLast - _pFirst) * sizeof(T));
				int nShift = _pFirst - _pBegin;
				_pFirst = _pBegin; _pLast -= nShift;
			}
			else {
				int nDesired = _pLast - _pFirst + pL - pF;
				int nActual = _pEnd - _pBegin;
				while ((nActual <<= 1)<nDesired);
				T *pNew = new T[nActual];
				CopyMemory(pNew, _pFirst, (_pLast - _pFirst) * sizeof(T));
				int nSize = _pLast - _pFirst;
				_pFirst = pNew; _pLast = _pFirst + nSize;
				delete[] _pBegin;
				_pEnd = (_pBegin = pNew) + nActual;
			}
			CopyMemory(_pLast, pF, (pL - pF) * sizeof(T));
			_pLast += pL - pF;
			if (_nDesired != 0 && size() >= _nDesired) {
				SetEvent(_hEvReach);
				_nDesired = 0;
			}
		}
		void front_erase(int nS) {
			_pFirst += nS;
			optimize_size();
		}
		void back_erase(int nS) {
			_pLast -= nS;
			optimize_size();
		}
		void clear() {
			_pLast = _pFirst = _pBegin;
			optimize_size();
		}
	private:
		HANDLE _hEvReach;
		int _nDesired;
		CRITICAL_SECTION _csAccess;
		void optimize_size() {
		}
		T *_pFirst;
		T *_pLast;
		T *_pBegin;
		T *_pEnd;
	};
int main()
{


	const int nSizes = 16;
	const int pSizes[nSizes] = {
		0x1000,0x2000,0x4000,0x8000, /* 4K..32K */
		0x10000,0x20000,0x40000,0x80000, /* 64K..512K */
		0x100000,0x200000,0x400000,0x800000, /* 1M..8M */
		0x1000000,0x2000000,0x4000000,0x8000000 /* 16M..128M */
	};

	const int nMinimalSize = 4096;
	
    return 0;
	std::cin.get();
		
}

