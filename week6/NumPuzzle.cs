using System;

public class NumPuzzle {
	public string name;
	private int [,] mData;
	private int mSize;
	private int zeroX;
	private int zeroY;
	private int findX;
	private int findY;
	private int mCount;
	public void Init(int size) {
		//mSize에도 적당한 값을 넣어 줍니다.
		//size 만큼 mData 배열을 초기화
		//1~size^2-1 값을 넣어 줍니다.
		//마지막에는 0을 넣어 줍니다.
		mSize = size;	
		mData = new int [size, size];
		mCount = 0;
	
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				mData[i, j] = i * size + j + 1;
			}
		}
		mData [size -1, size - 1] = 0;
		Print();
	}
	public string FindMove() {
		string ret = "";
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				if(IsMove(i, j)) { 
					if (ret.Equals("")) {
						ret = "" + mData[i, j];
					}else {
						ret = ret + " "  + mData[i, j];
					}
				}
			}
		}
		return ret;
	}
	private void Print() {
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				Console.Write("{0} ", mData[i, j]);
			}
			Console.WriteLine();
		}
	}
	private bool IsMove(int row, int col) {
		//mData[row,col] -- true
		//false
		if(col > 0 && mData[row, col - 1] == 0) return true;
		else if(col < (mSize - 1) && mData[row, col + 1] == 0) return true;
		else if(row > 0 && mData[row - 1, col] == 0) return true;
		else if(row < (mSize - 1) && mData[row + 1, col] == 0) return true;
		else return false;
	}
	private void ZeroLocation() {
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				if (mData[i, j] == 0) {
					zeroX = i;
					zeroY = j;
				}
			}
		}
	}
	private void FindLocation(int a) {
		for (int i = 0; i < mSize; i++) {
			for (int j = 0; j < mSize; j++) {
				if(mData[i, j] == a) {
					findX = i;
					findY = j;
					return;
				}
			}
		}
	}
	private bool IsValid(int a) {
		return (a <= (mSize * mSize) && a > 0);
	}
	public bool Move(int a) {
		if(IsValid(a)) {
			FindLocation(a);
			if(IsMove(findX, findY)) {
				Swap(findX, findY);
				return true;
			} else {
				Console.WriteLine("You can't move that location!!");
				return false;
			}
		} else {
			Console.WriteLine("The number isn't in the valid range!!");
			return false;
		}
	}
	private void Swap(int a, int b) {
		ZeroLocation();
		int temp = mData[zeroX, zeroY];
		mData[zeroX, zeroY] = mData[a, b];
		mData[a, b] = temp;
		mCount++;
	}
	public int GetTurn() {
		return mCount;
	}
}

class Test {
	static void Fail(string msg) {
		Console.WriteLine(msg);
		Environment.Exit(1);
	}
	static void Main() {
		NumPuzzle np1 = new NumPuzzle();
		
		np1.Init(3); // 1 2 3 4 5 6 7 8 0
		//init test
		//if(np1.mSize != 3) Fail("init test fail");
		//if(np1.mData[np1.mSize - 1, np1.mSize - 1] != 0) Fail("int test2 fail");

		//Console.WriteLine("init test success");

		//test 1
		string av = np1.FindMove();
		Console.WriteLine(av);
		if (av != "6 8") Fail("test1 fail");
		Console.WriteLine("test1 success!");
	}
}
