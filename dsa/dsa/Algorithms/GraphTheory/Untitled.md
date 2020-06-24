int nTests = int.Parse(Console.ReadLine());
	  
	  for(int i=0;i<nTests;i++){
	      string[] line1 = (Console.ReadLine()).Split(' ');
	      int k = int.Parse(line1[1]);
	      
	      string[] line2 =(Console.ReadLine()).Split(' ',StringSplitOptions.RemoveEmptyEntries);
	      int[] arr = Array.ConvertAll(line2,int.Parse);
	      Console.WriteLine(MaxSubArraySum(arr,k));
	  }