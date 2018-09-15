import itertools
import random
import sys

from bottle import default_app, route, run, template, static_file, \
	request, get, post, response, redirect
import bottlesession
from json import dumps, loads
from sudokuMaster import *
from models.login import *
from models.createDB import *

session_manager = bottlesession.CookieSession()

def redirectToIndex():
    session = session_manager.get_session()
    if session.get("id"):
        redirect("/")
        
def redirectToLogin():
    session = session_manager.get_session()
    if not session.get("id"):
        redirect("/login")

@route('/static/<filename:path>')
def send_static(filename):
    return static_file(filename, root='./static')
    
@route('/')
def index():
    session = session_manager.get_session()
    return template('index.tpl' , session=session)

@route('/contact_us')
def contact_us():
    session = session_manager.get_session()
    return template('contact_us.tpl',session=session)
    
@route('/rules')
def rules():
    session = session_manager.get_session()
    return template('rules.tpl',session=session)

@route('/get_board')
def get_board():
    board = make_board(3)
    puzzle = create_puzzle(board)
    session = session_manager.get_session()
    session['board'] = board
    session['puzzle'] = puzzle
    session_manager.save(session)
    response.content_type = 'application/json'
    return dumps({"board": puzzle})

@post('/check_solution')
def check_solution():
    session = session_manager.get_session()
    board = session.get('board')
    puzzle = session.get('puzzle')
    gameData = request.json
    answer = gameData['answer']
    
    won, results = check_answer(board, puzzle, answer)
    
    return dumps({"won": won, "results": results}) 

@route('/register')
def register():
    redirectToIndex()
    response.add_header('cache-control', 'no-cache, no-store, must-revalidate')
    response.add_header('pragma', 'no-cache')
    response.add_header('expires', '0')
    return template('register.tpl')

@route('/reset_password')
def reset_password():
    redirectToIndex()
    response.add_header('cache-control', 'no-cache, no-store, must-revalidate')
    response.add_header('pragma', 'no-cache')
    response.add_header('expires', '0')
    return template('reset_password.tpl')

@route('/edit_profile')
def edit_profile():
    redirectToLogin()
    session = session_manager.get_session()
    return template('edit_profile.tpl', session=session)

@route('/initDB')
def init_db():
    createTables()
    insertRecords()
    
@route('/login')
def login():
    redirectToIndex()
    session = session_manager.get_session()
    session['userId'] = random.randrange(1,100)
    session_manager.save(session)
    response.add_header('cache-control', 'no-cache, no-store, must-revalidate')
    response.add_header('pragma', 'no-cache')
    response.add_header('expires', '0')
    
    return template('login.tpl')

@route('/logout')
def logout():
    logoutUser()
    redirect('/')

@post('/userLogin')
def doLogIn():
    msg = userLogin(request.forms.get("txtLogEmail"),request.forms.get("txtLogPass"))
    return msg

@post('/forgotPassword')
def forgotPass():
    msg = getSecreatQuestionByEmail(request.forms.get("email"))
    return msg
    
@post('/submitSecrets')
def submitSecrets():
    return matchSecreatAnswers(request.forms.get("txtRegScrA"))

@post('/setNewPassword')
def setNewPassword():
    return resetNewPassword(request.forms.get("txtResetPass"))

@post('/registerUser')
def registerUser():
    return registerNewUser(request.forms.get("txtRegName"),
                        request.forms.get("txtRegPass"),
                        request.forms.get("txtRegZip"),
                        request.forms.get("txtRegEmail"),
                        request.forms.get("txtRegScrQ"),
                        request.forms.get("txtRegScrA"),)

@post('/editProfile')
def editUserProfile():
    return updateUserProfile(
                        request.forms.get("txtEditName"),
                        request.forms.get("txtEditPass"),
                        request.forms.get("txtEditZip"),
                        request.forms.get("txtEditEmail"),
                        request.forms.get("txtEditScrQ"),
                        request.forms.get("txtEditScrA"),)


@route('/get_board/<level>')
def getNewBoard(level):
    board = make_board(3)
    puzzle = create_puzzle(board, level)
    session = session_manager.get_session()
    session['board'] = board
    session['puzzle'] = puzzle
    session_manager.save(session)
    response.content_type = 'application/json'
    return dumps({"board": puzzle})

run(host='localhost', port=8088, debug="True", reloader="True")

# application = default_app()
