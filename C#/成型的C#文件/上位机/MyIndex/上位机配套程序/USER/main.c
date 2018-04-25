#include "stm32f10x.h"
#include "delay.h"
#include "sys.h"
#include "usart.h"
float test=1000.02;
void usart1_send_char(u8 c)
{
	while((USART1->SR&0X40)==0);
	USART1->DR=c;   	
} 
void  sendDate(float date1,u8 date)
{
	 u8 i=0;
  u8 tbuf[7]; 
	 union B_F
	 {
		  float f;
		  char Byte[4];
	 }bf;
	 bf.f=date1;
	 tbuf[0]=0X0A;//帧头
	 tbuf[1]=bf.Byte[0];
	 tbuf[2]=bf.Byte[1];
	 tbuf[3]=bf.Byte[2];
	 tbuf[4]=bf.Byte[3];
	 tbuf[5]=date;
	 tbuf[6]=0X0B;//帧尾
	 for(i=0;i<7;i++)usart1_send_char(tbuf[i]);
}
int len=0;
int t=0;
int receiveDate[15]={0};
int main(void)
{
	delay_init();	  	 //延时函数初始化	  
	NVIC_PriorityGroupConfig(NVIC_PriorityGroup_2); //设置NVIC中断分组2:2位抢占优先级，2位响应优先级
	uart_init(9600);	 //串口初始化为9600
	while (1)
	{
	  if(USART_RX_STA&0x8000)
		{					
			len=USART_RX_STA&0x3fff;
			for(t=0;t<len;t++)
			{
				receiveDate[t]=USART_RX_BUF[t];
			}
			USART_RX_STA=0;
		}
		sendDate((float)((receiveDate[0]<<8)|receiveDate[1]),0XA1);
		sendDate((float)((receiveDate[2]<<8)|receiveDate[3]),0XA2);
		sendDate((float)((receiveDate[4]<<8)|receiveDate[5]),0XA3);
		sendDate((float)((receiveDate[6]<<8)|receiveDate[7]),0XA4);
	} 
}

