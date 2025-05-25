/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package servicios;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import models.Mecanico;

/**
 *
 * @author Windows
 */
public class MecanicoService {
       public static Mecanico obtenerMecanico() {
        try {
            URL url = new URL("http://localhost:5062/api/Mecanico");
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");

            // Si usas HTTPS local con certificado autofirmado, puede que necesites configurar confianza

            BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));
            StringBuilder json = new StringBuilder();
            String line;
            while ((line = reader.readLine()) != null) {
                json.append(line);
            }
            reader.close();

            com.google.gson.Gson gson = new com.google.gson.Gson();
            System.out.println("trae json "+json.toString());
        
            
          
           return gson.fromJson(json.toString(), Mecanico.class);
            


        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
       }
}
