# chen thu vien
import pandas as pd
import numpy as np
import os

# load DT
from sklearn import tree
from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score, classification_report

# load dataset from csv file 
# data = pd.read_csv('./Data/abalone.data') 
data = pd.read_csv('./Data/abalone.data') 
data.head()

from sklearn import preprocessing
le = preprocessing.LabelEncoder()
for column_name in data.columns:
	if data[column_name].dtype == object:
		data[column_name] = le.fit_transform(data[column_name])
	else:
		pass

# tach nhan tap du lieu
y = data.iloc[: , 0]
X = data.iloc[:, 1:17]

clf = tree.DecisionTreeClassifier()

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.3)

print("Training size: %d" % len(y_train))
print("Test size    : %d" % len(y_test))

from sklearn.tree import DecisionTreeClassifier 

clf= DecisionTreeClassifier()
clf.fit(X_train, y_train)

y_pred = clf.predict(X_test)

print("Print results for 2 test data points:")
print("Predicted labels: ", y_pred[15:35])
print("Ground truth    : ", y_test[15:35])

print("Accuracy of Decision tree: %.2f %%" % ( 100 * accuracy_score(y_test, y_pred)))
print('Classification Report:\n{}\n'.format(classification_report(y_test,clf.predict(X_test))))


