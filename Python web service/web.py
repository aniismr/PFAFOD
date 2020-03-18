#!/usr/bin/env python
# coding: utf-8

# In[3]:


import flask
import PyPDF2 
import textract
import nltk
from nltk.tokenize import word_tokenize
from nltk.corpus import stopwords
import nltk
nltk.download('punkt')

from nltk import word_tokenize,sent_tokenize
from flask import request, jsonify
app = flask.Flask(__name__)
app.config["DEBUG"] = True


@app.route('/', methods=['GET'])
def home():
    
    return {"name":"ali"}

@app.route('/api', methods=['GET'])
def api_id():
    
    if 'id' in request.args:
        ide = str(request.args['id'])
    else:
        return "Error: No id field provided. Please specify an id."
    results = []
    d={}
    b={}
    #write a for-loop to open many files -- leave a comment if you'd #like to learn how
    filename = ide+'.pdf'
    #open allows you to read the file
    pdfFileObj = open(filename,'rb')
    #The pdfReader variable is a readable object that will be parsed
    pdfReader = PyPDF2.PdfFileReader(pdfFileObj)

    #discerning the number of pages will allow us to parse through all #the pages
    num_pages = pdfReader.numPages
    count = 0
    text = ""
    #The while loop will read each page
    while count < num_pages:
        pageObj = pdfReader.getPage(count)
        count +=1
        text += pageObj.extractText()
    #This if statement exists to check if the above library returned #words. It's done because PyPDF2 cannot read scanned files.
    if text != "":
        text = text
    #If the above returns as False, we run the OCR library textract to #convert scanned/image based PDF files into text
    else:
        text = textract.process(filename, method='tesseract', language='eng')
    print(type(text))
    text=text.replace('\n',' ')
    l=[]
    l=text.split(' ')
    l=[x.upper() for x in l]

    for i in l:
        if '@' in i:
            mail=i
            d['mail']=mail
    
    tokens = word_tokenize(text)
    #we'll create a new list which contains punctuation we wish to clean
    punctuations = ['(',')',';',':','[',']',',',':',' ']
    skills=['Matlab','matlab','MATLAB','C++','Pascal','c++','PHP','SQL']
    for i in range(0,len(tokens)-1):
        l.append(tokens[i]+tokens[i+1])
    keywords = [word for word in tokens if word in skills  ]
    keyw=[word for word in l if word in skills  ]
    s=set(keywords+keyw)
    l1=list(s)
    b['competence']=l1
    
    results.append(d)
    results.append(b)
    return jsonify(results)

    
app.run()


# In[ ]:




