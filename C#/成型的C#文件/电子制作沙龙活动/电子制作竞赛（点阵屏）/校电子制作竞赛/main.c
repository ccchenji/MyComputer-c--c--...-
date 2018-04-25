/**************************************************************************************
		              8*8LED点阵———显示数字实验																						  
***************************************************************************************/

#include "reg52.h"			 //此文件中定义了单片机的一些特殊功能寄存器
#include "Picture.h"
#include "allnum.h"
#include "AD.h"
#include "Snake.h"
/*******************************************************************************
* 函 数 名       : main
* 函数功能		 : 主函数
* 输    入       : 无
* 输    出    	 : 无
*******************************************************************************/
sbit Key1=P2^1;
void main()
{		
	Timer0Init();
	InitADC();
	while(1)
	{
	  My_Snake();
  }
}
