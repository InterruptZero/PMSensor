# PMSensor
A PM2.5&amp;PM10 sensor by using plantower PMS1003
## Usage
### Connect Device
You may need a **USB-TTL Serial** converter to connect the sensor.
Connect Gnd,Vcc,Rxd,Txd and connect computer.
### Start
Click **Connect** then connect.
You can choose CF=1 or STD.
The AQI compute may not exact.
## Program struct
Images:Same with Resources
Resources:the image resources
- green:green background
- yellow:yellow background
- orange:orange background
- red:red background
- purple:purple background
- deep:deep-red background
- what:background when Unconnected
Form1.cs:main code
- Byte2Hex:Convert two bytes to a hex
- InitPortscb:Init the port combobox and event
- ParseData:Parse the data from serial
- CalcLev:compute the air level
- AQIColor:return a image in resources by AQI
- CalcIAQI:compute the IAQI
- CalcAQI:compute the AQI
- Connectbtn_Click:when connect button click
