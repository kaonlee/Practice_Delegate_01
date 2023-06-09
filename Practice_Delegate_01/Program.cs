﻿namespace Practice_Delegate_01
{
	internal class Program
	{
		static void Main( string [] args )
		{
			int height = 7;
			//DrawLeftRightTriangle
			Console.WriteLine( "DrawLeftRightTriangle" );
			Triangle.Draw( height, stars => new string( '*', stars ));
			//DrawRightTriangle
			Console.WriteLine( "DrawRightTriangle" );
			Triangle.Draw( height, stars => new string( '*', stars ).PadLeft(height) );
			//DrawIsoscelesTriangle
			Console.WriteLine( "DrawIsoscelesTriangle" );
			Triangle.Draw( height, stars => new string( ' ', height - stars ) + new string( '*', stars * 2 - 1 ) );
			
			
			//DrawUSD LeftRightTriangle
			Console.WriteLine("Draw *UpSideDown* LeftRightTriangle");   
			Triangle.DrawUSD(height, stars => new string('*', stars));
			//DrawUSD RightTriangle
			Console.WriteLine("Draw *UpSideDown* RightTriangle");
			Triangle.DrawUSD(height, stars => new string('*', stars).PadLeft(height));
			//DrawUSD IsoscelesTriangle
			Console.WriteLine("Draw *UpSideDown* IsoscelesTriangle");
			Triangle.DrawUSD(height, stars => new string(' ', height - stars) + new string('*', stars * 2 - 1));

		}
	}

	public class Triangle
	{
		public static void Draw(int height, Func<int, string> func )
		{
			for ( int rowIndex = 1; rowIndex < height; rowIndex++ )
			{
				Console.WriteLine( func( rowIndex ) );
			}
		}
		public static void DrawUSD (int height, Func<int, string> func)
		{
			for (int rowIndex = height; rowIndex>0; rowIndex-- )
			{
				Console.WriteLine(func(rowIndex ) );
			}
}
	}
}


///// <summary>
//// 靠左星形三角形
///// *
///// **
///// ***
///// ****
///// *****
///// </summary>
//private static void Demo04A()
//{
//	for ( int rowIndex = 1; rowIndex <= 5; rowIndex++ )
//	{
//		string row = new string( '*', rowIndex );
//		Console.WriteLine( row );
//	}
//}

//// <summary>
//// 靠右星形三角形
/////     *
/////    **
/////   ***
/////  ****
///// *****
///// </summary>
//private static void Demo04B()
//{
//	for ( int rowIndex = 1; rowIndex <= 5; rowIndex++ )
//	{
//		string row = new string( '*', rowIndex );
//		row = row.PadLeft( 5 ); // 靠右對齊, 佔9個字元
//		Console.WriteLine( row );
//	}
//}

///// <summary>
//// 置中星形三角形
/////    *
/////   ***
/////   *****
/////  *******
///// *********
///// </summary>
//private static void Demo04C()
//{
//	for ( int rowIndex = 1; rowIndex <= 5; rowIndex++ )
//	{
//		string spaces = new string( ' ', 5 - rowIndex ); // 空白字元
//		string row = new string( '*', rowIndex * 2 - 1 ); // 星號字元
//		Console.WriteLine( spaces + row );
//	}
//}