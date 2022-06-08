import pandas as pd
import math
import matplotlib.pyplot as plt
import numpy as np

# Read the CSV into a pandas data frame (df)
#   With a df you can do many things
#   most important: visualize data with Seaborn
df = pd.read_csv('C:/Users/jonas/SynologyDrive/GIT/WORKING_WITH_YOUR_EYES/Calibration/python/5_30_22_normal.csv', delimiter=',')

xCoorTest = []
yCoorTest = []
twodDistance = []

for x in range(150):
    xCoorTest.append(0.05 * 1920)
    yCoorTest.append(0.05 * 1080)
    
for x in range(150):
    xCoorTest.append(0.05 * 1920)
    yCoorTest.append(0.95 * 1080)

for x in range(150):
    xCoorTest.append(0.95 * 1920)
    yCoorTest.append(0.05 * 1080)
    
for x in range(150):
    xCoorTest.append(0.95 * 1920)
    yCoorTest.append(0.95 * 1080)
    
for x in range(150):
    xCoorTest.append(0.50 * 1920)
    yCoorTest.append(0.50 * 1080)
    
for x in range(150):
    xCoorTest.append(0.25 * 1920)
    yCoorTest.append(0.50 * 1080)

for x in range(150):
    xCoorTest.append(0.50 * 1920)
    yCoorTest.append(0.25 * 1080)
    
for x in range(150):
    xCoorTest.append(0.75 * 1920)
    yCoorTest.append(0.50 * 1080)

for x in range(150):
    xCoorTest.append(0.50 * 1920)
    yCoorTest.append(0.75 * 1080)
    

df['xVal'] = xCoorTest
df['yVal'] = yCoorTest

for i in range(1350):
    x = df.loc[i,'x'] - df.loc[i,'xVal']
    y = df.loc[i,'y'] - df.loc[i,'yVal']
    distance = math.sqrt(x ** 2 + y ** 2)
    twodDistance.append(distance)

df['distance'] = twodDistance



captureCoor = df.plot(x ='x', y='y', kind = 'scatter', ylim = (0,1080), xlim = (0,1920), xticks = (np.arange(0, 1921, 240)), yticks = (np.arange(0, 1081, 135)), color = 'r', marker = '.', label = 'Captured data')
validateCoor = df.plot(x ='xVal', y='yVal', kind = 'scatter', ylim = (0,1080), xlim = (0,1920), color = 'b', marker = '.', ax = captureCoor, label = 'Validate data')

validateCoor.set_xlabel("X-coordinate (pixels)")
validateCoor.set_ylabel("Y-coordinate (pixels)")

validateCoor.invert_yaxis()
validateCoor.xaxis.set_label_position('top')

plt.rcParams['xtick.bottom'] = plt.rcParams['xtick.labelbottom'] = False
plt.rcParams['xtick.top'] = plt.rcParams['xtick.labeltop'] = True


df_point1 = df.loc[0:149]
df_point2 = df.loc[150:299]
df_point3 = df.loc[300:449]
df_point4 = df.loc[450:599]
df_point5 = df.loc[600:749]
df_point6 = df.loc[750:899]
df_point7 = df.loc[900:1049]
df_point8 = df.loc[1050:1199]
df_point9 = df.loc[1200:1349]

meanErrorPoint1 = df_point1['distance'].sum() / 150
meanErrorPoint2 = df_point2['distance'].sum() / 150
meanErrorPoint3 = df_point3['distance'].sum() / 150
meanErrorPoint4 = df_point4['distance'].sum() / 150
meanErrorPoint5 = df_point5['distance'].sum() / 150
meanErrorPoint6 = df_point6['distance'].sum() / 150
meanErrorPoint7 = df_point7['distance'].sum() / 150
meanErrorPoint8 = df_point8['distance'].sum() / 150
meanErrorPoint9 = df_point9['distance'].sum() / 150

