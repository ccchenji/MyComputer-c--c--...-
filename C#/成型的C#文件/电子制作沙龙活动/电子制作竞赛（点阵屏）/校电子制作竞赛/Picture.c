#include "Picture.h"

sbit SRCLK=P3^6;
sbit RCLK1=P3^5;
sbit SER=P3^4;
int timer=0;
int flag=0;
u8 ledwei[]={0x7f,0xbf,0xdf,0xef,0xf7,0xfb,0xfd,0xfe};
/*******************************************************************************
* 函 数 名         : delay
* 函数功能		   : 延时函数，i=1时，大约延时10us
*******************************************************************************/
void delay(u16 i)
{
	while(i--);	
}



/*******************************************************************************
* 函数名         : Hc595SendByte(u8 dat)
* 函数功能		   : 向74HC595发送一个字节的数据
* 输入           : 无
* 输出         	 : 无
*******************************************************************************/
void Hc595SendByte(u8 dat)
{
	u8 a;
	SRCLK=0;
	RCLK1=0;
	for(a=0;a<8;a++)
	{
		SER=dat>>7;
		dat<<=1;

		SRCLK=1;
		_nop_();
		_nop_();
		SRCLK=0;	
	}

	RCLK1=1;
	_nop_();
	_nop_();
	RCLK1=0;
}



/*******************************画点函数****************************************
* 函数名  :          DrawPoint(u8 x,u8 y) 
* x       :          点的X坐标值 1~8
* y       ：         点的y坐标值 1~8
*******************************************************************************/ 
void DrawPoint(u8 x,u8 y)
{
	 if(x>=1&&x<=8&&y>=1&&y<=8)
	 {
		   P0=0xff&(0xff7f>>(x-1));
			 Hc595SendByte(0x00|(0x01<<(y-1)));
	 }	
	     Hc595SendByte(0x00);
}



/*******************************显示一张图案*************************************
*功能     ：显示所想显示的一张图案
*roll[][] : 所得到的图案
*len      : 图案中点的个数
************************************************************************/
void pattren(u8 roll[8])
{
	  int i=0;
		P0=0x7f;
		for(i=0;i<8;i++)
		{
			P0=ledwei[i];		  //位选
			Hc595SendByte(roll[i]);	//发送段选数据
			delay(100);		   //延时
			Hc595SendByte(0x00);  //消隐
		}
}
/*************************字幕滚动函数************************************
*功能       ：使得到的图案横向移动
*roll       : 得到的图案
*screen_num : 所用到的屏幕数
*************************************************************************/
void char_roll(u8 roll[],short screen_num)
{
    int i=0;
	  int j=0;
	  int k=0;
	  int exchange=0;
		P0=0x7f;
	 for(k=0;k<8*screen_num;k++)
	{
	 for(j=0;j<80;j++)
	 {
	   for(i=0;i<8;i++)
	   {
		 	P0=ledwei[i];		  //位选
			Hc595SendByte(roll[i]);	//发送段选数据
			delay(100);		   //延时
			Hc595SendByte(0x00);  //消隐
	   }
	 } 
		exchange=roll[0];
		for(i=0;i<8*screen_num-1;i++)
		{
			 roll[i]=roll[i+1];
		}
		roll[8*screen_num-1]=exchange;
	}
}
