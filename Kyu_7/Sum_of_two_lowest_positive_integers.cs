public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
		for(int i=0;i<numbers.Length-1;i++)
      {
      bool check=false;
      for(int j=0;j<numbers.Length-i-1;j++){
        if(numbers[j]>numbers[j+1]){
          int temp=numbers[j];
          numbers[j]=numbers[j+1];
          numbers[j+1]=temp;
          check=true;
        }
      }
      if(check==false) break;
    }
    return numbers[0]+numbers[1];
	}
}
