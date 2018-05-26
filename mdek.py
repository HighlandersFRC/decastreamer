import serial
import time
import operator
import matplotlib.pyplot as plt

ser = serial.Serial(
    port='COM4',
    baudrate=115200,
    timeout=0.1
)

ser.write(b'\r\r')

res = ser.read(10)
time.sleep(0.5)

#ser.write(b'les\r')

ser.write(b'lep\r')

print(res)

final_list = []

def average_pts(alist):
    avg = (0, 0, 0)
    for i in range(3):
        avg = tuple(map(operator.add, avg, (alist[i][j] for j in range(3))))    
    return tuple(coord / 3 for coord in avg)
    
alist = []

while True:
    
    pt_count = 0
    res = ser.readline(100)
    if len(res) > 0:
        s = res.decode('utf-8')
        #pts = s.split(',')
        try:
            s = s.split(',')
            ##print(s)
            #del s[0]   
            #print(s)
            #if len(s) != 3:
            #    raise ValueError()
            pts = [float(p) for p in s[1:4]]
            if len(pts) != 3:
                raise ValueError
            ##print(pts)
            alist.append(pts)
        except ValueError:
            pass
            
        if len(alist) == 3:
            x,y,z = average_pts(alist)
            final_list.append([x, y, z])
            alist = []
            print ("Avg pts: {:.2f}, {:.2f}, {:.2f}".format(x,y,z))
            
        if len(final_list) >= 100:
            x_pts = list(pt[0] for pt in final_list)
            plt.hist(x_pts, 20)
            plt.show()
            final_list = []
            pass
            

#            print(s)
#            print (pts)
#            if pts == 3:
#            print ("x = {}, y = {}".format(pts[1], pts[2]))