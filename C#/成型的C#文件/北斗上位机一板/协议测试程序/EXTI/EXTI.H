#ifndef _EXTI_H
#define _EXTI_H
#include "stm32f10x.h"

#define A_Input() GPIO_ReadInputDataBit(GPIOB,GPIO_Pin_3)//�õ�Io�ڵ�״̬
#define B_Input() GPIO_ReadInputDataBit(GPIOB,GPIO_Pin_4)

void EXTIX_INIT(void);




#endif