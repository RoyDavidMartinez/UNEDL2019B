/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programacion3;

/**
 *
 * @author USER
 */
public class Operadores extends javax.swing.JFrame {

    /**
     * Creates new form Operadores
     */
    public Operadores() {
        initComponents();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        buttonGroup1 = new javax.swing.ButtonGroup();
        lTitulo = new javax.swing.JLabel();
        pFondoBlanco = new javax.swing.JPanel();
        lLogo = new javax.swing.JLabel();
        lbNumero = new javax.swing.JLabel();
        bSegundodato = new javax.swing.JLabel();
        txtPrimerDato = new javax.swing.JTextField();
        txtSegundoDato = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        rAritmeticos = new javax.swing.JRadioButton();
        rRelacionales = new javax.swing.JRadioButton();
        rEquidad = new javax.swing.JRadioButton();
        rLogicos = new javax.swing.JRadioButton();
        cbAritmeticos = new javax.swing.JComboBox();
        jComboBox1 = new javax.swing.JComboBox();
        jComboBox2 = new javax.swing.JComboBox();
        jComboBox3 = new javax.swing.JComboBox();
        jTextField1 = new javax.swing.JTextField();
        pFondoAzul = new javax.swing.JPanel();
        pFondoAmarillo = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        getContentPane().setLayout(null);

        lTitulo.setFont(new java.awt.Font("Arial", 3, 14)); // NOI18N
        lTitulo.setForeground(new java.awt.Color(255, 255, 255));
        lTitulo.setText("Obtencion de raices cuadradas por metodos iterativos");
        getContentPane().add(lTitulo);
        lTitulo.setBounds(10, 11, 480, 30);

        pFondoBlanco.setBackground(new java.awt.Color(255, 255, 255));
        pFondoBlanco.setForeground(new java.awt.Color(204, 0, 204));
        pFondoBlanco.setLayout(null);

        lLogo.setIcon(new javax.swing.ImageIcon("C:\\Users\\USER\\Pictures\\HyperX_200x200.jpg")); // NOI18N
        lLogo.setText("jLabel1");
        pFondoBlanco.add(lLogo);
        lLogo.setBounds(330, 20, 190, 80);

        lbNumero.setText("Primer dato:");
        pFondoBlanco.add(lbNumero);
        lbNumero.setBounds(70, 50, 190, 14);

        bSegundodato.setText("Segundo dato:");
        pFondoBlanco.add(bSegundodato);
        bSegundodato.setBounds(70, 80, 240, 14);

        txtPrimerDato.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtPrimerDatoActionPerformed(evt);
            }
        });
        txtPrimerDato.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtPrimerDatoKeyTyped(evt);
            }
        });
        pFondoBlanco.add(txtPrimerDato);
        txtPrimerDato.setBounds(220, 40, 90, 30);

        txtSegundoDato.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtSegundoDatoActionPerformed(evt);
            }
        });
        txtSegundoDato.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtSegundoDatoKeyTyped(evt);
            }
        });
        pFondoBlanco.add(txtSegundoDato);
        txtSegundoDato.setBounds(220, 70, 90, 30);

        jButton1.setText("Generar");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        pFondoBlanco.add(jButton1);
        jButton1.setBounds(440, 260, 73, 23);

        rAritmeticos.setBackground(new java.awt.Color(255, 255, 255));
        buttonGroup1.add(rAritmeticos);
        rAritmeticos.setText("Aritmeticos");
        pFondoBlanco.add(rAritmeticos);
        rAritmeticos.setBounds(30, 120, 79, 23);

        rRelacionales.setBackground(new java.awt.Color(255, 255, 255));
        buttonGroup1.add(rRelacionales);
        rRelacionales.setText("Relacionales");
        pFondoBlanco.add(rRelacionales);
        rRelacionales.setBounds(140, 120, 85, 23);

        rEquidad.setBackground(new java.awt.Color(255, 255, 255));
        buttonGroup1.add(rEquidad);
        rEquidad.setText("Equidad");
        pFondoBlanco.add(rEquidad);
        rEquidad.setBounds(260, 120, 63, 23);

        rLogicos.setBackground(new java.awt.Color(255, 255, 255));
        buttonGroup1.add(rLogicos);
        rLogicos.setText("Logicos");
        rLogicos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rLogicosActionPerformed(evt);
            }
        });
        pFondoBlanco.add(rLogicos);
        rLogicos.setBounds(370, 120, 93, 23);

        cbAritmeticos.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        pFondoBlanco.add(cbAritmeticos);
        cbAritmeticos.setBounds(40, 160, 56, 20);

        jComboBox1.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        pFondoBlanco.add(jComboBox1);
        jComboBox1.setBounds(150, 160, 56, 20);

        jComboBox2.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        pFondoBlanco.add(jComboBox2);
        jComboBox2.setBounds(260, 160, 56, 20);

        jComboBox3.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        pFondoBlanco.add(jComboBox3);
        jComboBox3.setBounds(370, 160, 56, 20);

        jTextField1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField1ActionPerformed(evt);
            }
        });
        pFondoBlanco.add(jTextField1);
        jTextField1.setBounds(70, 260, 210, 50);

        getContentPane().add(pFondoBlanco);
        pFondoBlanco.setBounds(0, 60, 540, 340);

        pFondoAzul.setBackground(new java.awt.Color(0, 0, 153));

        pFondoAmarillo.setBackground(new java.awt.Color(255, 204, 51));

        javax.swing.GroupLayout pFondoAmarilloLayout = new javax.swing.GroupLayout(pFondoAmarillo);
        pFondoAmarillo.setLayout(pFondoAmarilloLayout);
        pFondoAmarilloLayout.setHorizontalGroup(
            pFondoAmarilloLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 540, Short.MAX_VALUE)
        );
        pFondoAmarilloLayout.setVerticalGroup(
            pFondoAmarilloLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 9, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout pFondoAzulLayout = new javax.swing.GroupLayout(pFondoAzul);
        pFondoAzul.setLayout(pFondoAzulLayout);
        pFondoAzulLayout.setHorizontalGroup(
            pFondoAzulLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(pFondoAmarillo, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        pFondoAzulLayout.setVerticalGroup(
            pFondoAzulLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, pFondoAzulLayout.createSequentialGroup()
                .addContainerGap(50, Short.MAX_VALUE)
                .addComponent(pFondoAmarillo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(41, 41, 41))
        );

        getContentPane().add(pFondoAzul);
        pFondoAzul.setBounds(0, 0, 540, 100);

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void txtPrimerDatoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtPrimerDatoActionPerformed

    }//GEN-LAST:event_txtPrimerDatoActionPerformed

    private void txtPrimerDatoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtPrimerDatoKeyTyped
        int numero = evt.getKeyChar();
        if (Character.isLetter(numero)) {
            evt.consume();
        }
    }//GEN-LAST:event_txtPrimerDatoKeyTyped

    private void txtSegundoDatoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtSegundoDatoActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtSegundoDatoActionPerformed

    private void txtSegundoDatoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtSegundoDatoKeyTyped
        int numero = evt.getKeyChar();
        if (Character.isLetter(numero)) {
            evt.consume();
        }
        // TODO add your handling code here:
    }//GEN-LAST:event_txtSegundoDatoKeyTyped

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
    
        
        // TODO add your handling code here:
    }//GEN-LAST:event_jButton1ActionPerformed

    private void rLogicosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rLogicosActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_rLogicosActionPerformed

    private void jTextField1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Operadores.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Operadores.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Operadores.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Operadores.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Operadores().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel bSegundodato;
    private javax.swing.ButtonGroup buttonGroup1;
    private javax.swing.JComboBox cbAritmeticos;
    private javax.swing.JButton jButton1;
    private javax.swing.JComboBox jComboBox1;
    private javax.swing.JComboBox jComboBox2;
    private javax.swing.JComboBox jComboBox3;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JLabel lLogo;
    private javax.swing.JLabel lTitulo;
    private javax.swing.JLabel lbNumero;
    private javax.swing.JPanel pFondoAmarillo;
    private javax.swing.JPanel pFondoAzul;
    private javax.swing.JPanel pFondoBlanco;
    private javax.swing.JRadioButton rAritmeticos;
    private javax.swing.JRadioButton rEquidad;
    private javax.swing.JRadioButton rLogicos;
    private javax.swing.JRadioButton rRelacionales;
    private javax.swing.JTextField txtPrimerDato;
    private javax.swing.JTextField txtSegundoDato;
    // End of variables declaration//GEN-END:variables
}
