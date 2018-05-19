<p>
    修改 IP 地址&nbsp; FE 07 90 21 00 00 11&nbsp; 02 01&nbsp; FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FE 05 21 90 00 00 00 FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 地址 0x0102</p>
<p>
&nbsp;修改网络 ID&nbsp; FE 07 90 21 00 00 12&nbsp;&nbsp; 05 28&nbsp; FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FE 05 21 90 00 00 00 FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 网络 ID 0x2805</p>
<p>
    修改信道&nbsp;&nbsp;&nbsp; FE 06 90 21 00 00 13&nbsp;&nbsp; 15&nbsp;&nbsp; FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FE 05 21 90 00 00 00 FF&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 信道 0x15</p>
<p>
    重启包&nbsp;&nbsp;&nbsp; FE 05 90 21 00 00 10 FF </p>
<p>
    &nbsp;</p>
<p>
    MCU 采集到温湿度为温度 23℃,湿度 60%,则无线传输的数据是 0x17，0x3C。</p>
<p>
    节点和电脑都使用 A0 端口传输温度，A1端口传输湿度，MCU 已知连接电脑的模块地址为 0x000F，</p>
<p>
    则 MCU发给模块的数据为： FE 05 A0 A0 0F 00 17 FF&nbsp;&nbsp;&nbsp;&nbsp; FE 05 A1 A1 0F 00 3C FF
</p>
<p>
    则电脑串口收到的数据为： FE 05 A0 A0 01 00 17 FF&nbsp;&nbsp;&nbsp;&nbsp; FE 05 A1 A1 01 00 3C FF
</p>
<p>
    电脑串口收到的数据中远程地址被替换为了源节点的地址。</p>
<p>
    &nbsp;</p>
<p>
    将数据 00 AE 13 33 发往地址为 0003 的模块，目标端口为 90，源端口为 91。</p>
<p>
    FE 08&nbsp; 91 90&nbsp; 03 00&nbsp; 00 AE 13 33&nbsp; FF</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    包头 2byte 包头由 FE 和 包的长度组成，长度为包的数据长度加 4。FE 08
</p>
<p>
    源端口号 1byte 包的源端口号。 91 </p>
<p>
    目的端口号 1byte 包的目的端口号。 90
</p>
<p>
    远程地址 2byte 远程模块的地址，当发送数据给模块时，远程地址为目标模块的地址，目标地址为 0x0000表示此包发给本模块，目标地址为 0xFFFF的包会被发往本网络中的所有节点。当从模块接收数据时，远程地址是数据的源地址。 03 00
</p>
<p>
    数据 可变 想要传输的数据。 00 AE 13 33
</p>
<p>
    包尾 1byte 固定为 FF 表示一个包传输完成。 FF</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
