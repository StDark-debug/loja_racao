import urllib.request, urllib.parse, urllib.error
import json


api_key = "AIzaSyDwcgR48P9IPxyf_XMaSiQLtS9dSSSFx-w"


# ponto de partida
partida = ("Avenida Brigadeiro José Vicente Faria Lima 2010")

# destino
arquivo_destino = open ("C:/Users/endot/source/repos/loja_racao/loja_racao/bin/Debug/Export/endereco.txt", "r")
destino = (arquivo_destino.read())
arquivo_destino.close()

#base url
url_servico = "https://maps.googleapis.com/maps/api/distancematrix/json?"

# get response


url = (url_servico + urllib.parse.urlencode({'origins' : partida}) + "&" + urllib.parse.urlencode({'destinations' : destino}) + "&key=" + api_key)
print (url)
uh = urllib.request.urlopen(url)
data = uh.read().decode()
#print ('Retrieved', len(data), 'characters')


try:
        js = json.loads(data)
except:
        js = None
    
if not js or 'status' not in js or js ['status'] != 'OK':
        print ('==== Failure To Retrieve ====')
        print (data)

distance = js ["rows"][0]["elements"][0]["distance"]["text"]      

pos = distance.find(".")
distance_w = distance[:pos+2]

distance_archive = open ("C:/Users/endot/source/repos/loja_racao/loja_racao/bin/Debug/Export/distancia.txt", "w")
distance_archive.write (distance_w)
distance_archive.close()

