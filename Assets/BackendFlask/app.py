# import sqlite3

# connection = sqlite3.connect('Highscores.db')
# cursor = connection.cursor()
# cursor.execute('''CREATE TABLE IF NOT EXISTS Highscores
#               (Name TEXT, Highscore INT)''')

import json
from flask import Flask, session, redirect, url_for, escape, request, Markup, render_template
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy.sql import text

app=Flask(__name__)
app.secret_key=b'adham'
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///Highscores.db'
db = SQLAlchemy(app)

@app.route('/HighScore',methods=['GET'])
def HighScoreGET():
    sql1 = """
          SELECT *
          FROM Highscores
          """
    results = db.engine.execute(text(sql1))
    print(results)    
    response = {}
    i = 1
  
    # ITERATE OVER EACH RECORD IN RESULT AND ADD IT 
    # IN A PYTHON DICT OBJECT
    for each in results:
        response.update({each.Name: each.Highscore})
        i+= 1
    return response

@app.route('/HighScore',methods=['POST'])
def HighScorePOST():
    Name = request.args['Name']
    ScoreValue = request.args['Score']
    updateSQL="""INSERT into Highscores (Name,Highscore)
                  values ('{}','{}')""".format(Name,ScoreValue)
    db.engine.execute(text(updateSQL))
    return "Success"
    
if __name__=="__main__":
	app.run(debug=True)