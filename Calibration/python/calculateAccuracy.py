import pandas as pd
import math
import matplotlib.pyplot as plt
import numpy as np

df = pd.read_csv('C:/Users/jonas/SynologyDrive/GIT/WORKING_WITH_YOUR_EYES/Calibration/python/cal_reflecting_sunglasses_3.csv', delimiter=',')
#df = pd.read_csv('C:/Users/jonas/SynologyDrive/GIT/WORKING_WITH_YOUR_EYES/Calibration/python/sunlight_on_tracker_test1.csv', delimiter=',')


xCoorTest = []
yCoorTest = []
twodDistance = []
tempSDList = []
tempPrecisionList = []

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

plt.savefig('reflectingSunglasses.png', dpi=300, bbox_inches = "tight")


############## ACCURACY: MEAN ERROR ##############

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

totalMeanError = (meanErrorPoint1 + meanErrorPoint2 + meanErrorPoint3 + meanErrorPoint4 + meanErrorPoint5 + meanErrorPoint6 + meanErrorPoint7 + meanErrorPoint8 + meanErrorPoint9)/9


############## PRECISION: STANDARD DEVIATION ##############

xCoorMean1 = df_point1['x'].sum() / 150
yCoorMean1 = df_point1['y'].sum() / 150
xCoorMean2 = df_point2['x'].sum() / 150
yCoorMean2 = df_point2['y'].sum() / 150
xCoorMean3 = df_point3['x'].sum() / 150
yCoorMean3 = df_point3['y'].sum() / 150
xCoorMean4 = df_point4['x'].sum() / 150
yCoorMean4 = df_point4['y'].sum() / 150
xCoorMean5 = df_point5['x'].sum() / 150
yCoorMean5 = df_point5['y'].sum() / 150
xCoorMean6 = df_point6['x'].sum() / 150
yCoorMean6 = df_point6['y'].sum() / 150
xCoorMean7 = df_point7['x'].sum() / 150
yCoorMean7 = df_point7['y'].sum() / 150
xCoorMean8 = df_point8['x'].sum() / 150
yCoorMean8 = df_point8['y'].sum() / 150
xCoorMean9 = df_point9['x'].sum() / 150
yCoorMean9 = df_point9['y'].sum() / 150

for i in range(150):
    distanceToMeanSquared = (math.sqrt( (df_point1.loc[i,'x'] - xCoorMean1) ** 2 + (df_point1.loc[i,'y'] - yCoorMean1) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation1 = math.sqrt(sum(tempSDList)/150)

for i in range(150,300):
    distanceToMeanSquared = (math.sqrt( (df_point2.loc[i,'x'] - xCoorMean2) ** 2 + (df_point2.loc[i,'y'] - yCoorMean2) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation2 = math.sqrt(sum(tempSDList)/150)

for i in range(300,450):
    distanceToMeanSquared = (math.sqrt( (df_point3.loc[i,'x'] - xCoorMean3) ** 2 + (df_point3.loc[i,'y'] - yCoorMean3) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation3 = math.sqrt(sum(tempSDList)/150)

for i in range(450,600):
    distanceToMeanSquared = (math.sqrt( (df_point4.loc[i,'x'] - xCoorMean4) ** 2 + (df_point4.loc[i,'y'] - yCoorMean4) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation4 = math.sqrt(sum(tempSDList)/150)

for i in range(600,750):
    distanceToMeanSquared = (math.sqrt( (df_point5.loc[i,'x'] - xCoorMean5) ** 2 + (df_point5.loc[i,'y'] - yCoorMean5) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation5 = math.sqrt(sum(tempSDList)/150)

for i in range(750,900):
    distanceToMeanSquared = (math.sqrt( (df_point6.loc[i,'x'] - xCoorMean6) ** 2 + (df_point6.loc[i,'y'] - yCoorMean6) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation6 = math.sqrt(sum(tempSDList)/150)

for i in range(900,1050):
    distanceToMeanSquared = (math.sqrt( (df_point7.loc[i,'x'] - xCoorMean7) ** 2 + (df_point7.loc[i,'y'] - yCoorMean7) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation7 = math.sqrt(sum(tempSDList)/150)

for i in range(1050,1200):
    distanceToMeanSquared = (math.sqrt( (df_point8.loc[i,'x'] - xCoorMean8) ** 2 + (df_point8.loc[i,'y'] - yCoorMean8) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation8 = math.sqrt(sum(tempSDList)/150)

for i in range(1200,1350):
    distanceToMeanSquared = (math.sqrt( (df_point9.loc[i,'x'] - xCoorMean9) ** 2 + (df_point9.loc[i,'y'] - yCoorMean9) ** 2))**2
    tempSDList.append(distanceToMeanSquared)

standardDeviation9 = math.sqrt(sum(tempSDList)/150)

totalSDError = (standardDeviation1 + standardDeviation2 + standardDeviation3 + standardDeviation4 + standardDeviation5 + standardDeviation6 + standardDeviation7 + standardDeviation8 + standardDeviation9) /9


############## PRECISION: RMS ##############

for i in range(149):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point1.loc[i,'x'] - df_point1.loc[i+1,'x']) ** 2 + (df_point1.loc[i,'y'] - df_point1.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision1 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(150,299):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point2.loc[i,'x'] - df_point2.loc[i+1,'x']) ** 2 + (df_point2.loc[i,'y'] - df_point2.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision2 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(300,449):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point3.loc[i,'x'] - df_point3.loc[i+1,'x']) ** 2 + (df_point3.loc[i,'y'] - df_point3.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision3 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(450,599):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point4.loc[i,'x'] - df_point4.loc[i+1,'x']) ** 2 + (df_point4.loc[i,'y'] - df_point4.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision4 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(600,749):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point5.loc[i,'x'] - df_point5.loc[i+1,'x']) ** 2 + (df_point5.loc[i,'y'] - df_point5.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision5 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(750,899):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point6.loc[i,'x'] - df_point6.loc[i+1,'x']) ** 2 + (df_point6.loc[i,'y'] - df_point6.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision6 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(900,1049):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point7.loc[i,'x'] - df_point7.loc[i+1,'x']) ** 2 + (df_point7.loc[i,'y'] - df_point7.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision7 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(1050,1199):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point8.loc[i,'x'] - df_point8.loc[i+1,'x']) ** 2 + (df_point8.loc[i,'y'] - df_point8.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision8 = math.sqrt(sum(tempPrecisionList)/149)

for i in range(1200,1349):
    distanceBetweenSuccessivePointsSquared = (math.sqrt( (df_point9.loc[i,'x'] - df_point9.loc[i+1,'x']) ** 2 + (df_point9.loc[i,'y'] - df_point9.loc[i+1,'y']) ** 2))**2
    tempPrecisionList.append(distanceBetweenSuccessivePointsSquared)

precision9 = math.sqrt(sum(tempPrecisionList)/149)

totalPrecision = (precision1 + precision2 + precision3 + precision4 + precision5 + precision6 + precision7 + precision8 + precision9) / 9


print("Accuracy = " + str(totalMeanError) + " | Precision = " + str(totalPrecision) + " | SDPrecision = " + str(totalSDError))

