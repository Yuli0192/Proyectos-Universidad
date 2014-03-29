package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;


/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaRegistarAbogado extends javax.swing.JFrame {
	private JTextField txtnomAbogado;
	private JButton btnRegresar;
	private JButton btnAgregar;
	private JLabel numColegiado;
	private JLabel numIdentificacion;
	private JLabel nomAbogado;
	private JTextField txtnumColegiado;
	private JTextField txtnumIdentificacion;
	Gestor gestor;
	
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegistarAbogado inst = new PantallaRegistarAbogado();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaRegistarAbogado() {
		super();
		initGUI();
		gestor = new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(69,174,231));
			this.setTitle("Registrar Administrador");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtnomAbogado = new JTextField();
				getContentPane().add(txtnomAbogado);
				txtnomAbogado.setBounds(167, 32, 197, 23);
			}
			{
				txtnumIdentificacion = new JTextField();
				getContentPane().add(txtnumIdentificacion);
				txtnumIdentificacion.setBounds(167, 77, 197, 23);
			}
			{
				txtnumColegiado = new JTextField();
				getContentPane().add(txtnumColegiado);
				txtnumColegiado.setBounds(167, 122, 197, 23);
			}
			{
				nomAbogado = new JLabel();
				getContentPane().add(nomAbogado);
				nomAbogado.setText("Nombre Administrador");
				nomAbogado.setBounds(12, 32, 155, 23);
			}
			{
				numIdentificacion = new JLabel();
				getContentPane().add(numIdentificacion);
				numIdentificacion.setText("Numero de Identificacion");
				numIdentificacion.setBounds(12, 77, 155, 23);
			}
			{
				numColegiado = new JLabel();
				getContentPane().add(numColegiado);
				numColegiado.setText("Numero de Colegiado");
				numColegiado.setBounds(12, 122, 155, 23);
			}
			{
				btnAgregar = new JButton();
				getContentPane().add(btnAgregar);
				btnAgregar.setText("Agregar");
				btnAgregar.setBounds(16, 189, 144, 53);
				
				btnAgregar.setBackground(new java.awt.Color(255,255,255));
				btnAgregar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnAgregar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregar.actionPerformed, event="+evt);
						//TODO add your code for btnAgregar.actionPerformed
						btnAgregar_actionPerformed(evt);
					}


				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(220, 189, 144, 53);
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}

				});
			}
			pack();
			setSize(400, 300);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}

	private void btnAgregar_actionPerformed(ActionEvent evt) {
		String mjs,numAbogado,numIdentificacion,numColegiado;

			try {
				numAbogado=txtnomAbogado.getText();
				numIdentificacion=txtnumIdentificacion.getText();
				numColegiado=txtnumColegiado.getText();
				//String pnumIdentAdministrador,String pnomAdministrador, String pnumColegiado
				mjs=gestor.AgregarAdministrador(numIdentificacion,numAbogado,numColegiado);
				JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
			
			} catch (Exception e) {
				// TODO Auto-generated catch block
				//e.printStackTrace();
			}
			

	}

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegistarAbogado.this.dispose();
	}
	
}
