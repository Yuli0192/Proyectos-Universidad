package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Date;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFormattedTextField;
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
public class PantallaRegistrarEmpresa extends javax.swing.JFrame {
	private JLabel numEmpresa;
	private JLabel direcEmpresa;
	private JTextField txtContactoEmpresa;
	private JLabel contEmpresa;
	private JButton btnRegresar;
	private JButton btnAgregarEmpresa;
	private JTextField txtTelEmpresa;
	private JTextField txtDirecEmpresa;
	private JTextField txtNomEmpresa;
	private JTextField txtNumEmpresa;
	private JLabel telEmpresa;
	private JLabel nomEmpresa;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegistrarEmpresa inst = new PantallaRegistrarEmpresa();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaRegistrarEmpresa() {
		super();
		initGUI();
		gestor=new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setBackground(new java.awt.Color(70,163,255));
			getContentPane().setLayout(null);
			this.setTitle("Agregar Empresa");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				numEmpresa = new JLabel();
				getContentPane().add(numEmpresa);
				numEmpresa.setText("Numero de empresa");
				numEmpresa.setBounds(25, 25, 123, 22);
			}
			{
				nomEmpresa = new JLabel();
				getContentPane().add(nomEmpresa);
				nomEmpresa.setText("Nombre Empresa");
				nomEmpresa.setBounds(25, 59, 120, 20);
			}
			{
				direcEmpresa = new JLabel();
				getContentPane().add(direcEmpresa);
				direcEmpresa.setText("Dirreción Empresa");
				direcEmpresa.setBounds(22, 96, 118, 16);
			}
			{
				telEmpresa = new JLabel();
				getContentPane().add(telEmpresa);
				telEmpresa.setText("Telefono Empresa");
				telEmpresa.setBounds(22, 131, 123, 16);
			}
			{
				txtNumEmpresa = new JTextField();
				getContentPane().add(txtNumEmpresa);
				txtNumEmpresa.setBounds(145, 25, 107, 23);
				
			}
			{

				txtNomEmpresa = new JTextField();
				getContentPane().add(txtNomEmpresa);
				txtNomEmpresa.setBounds(145, 58, 214, 23);
				
			}
			{
				txtDirecEmpresa = new JTextField();
				getContentPane().add(txtDirecEmpresa);
				txtDirecEmpresa.setBounds(145, 93, 214, 23);
			}
			{
				txtTelEmpresa = new JTextField();
				getContentPane().add(txtTelEmpresa);
				txtTelEmpresa.setBounds(145, 128, 214, 23);
			}
			{
				btnAgregarEmpresa = new JButton();
				getContentPane().add(btnAgregarEmpresa);
				btnAgregarEmpresa.setText("Agregar");
				btnAgregarEmpresa.setBounds(22, 208, 136, 42);
				btnAgregarEmpresa.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnAgregarEmpresa.setBackground(new java.awt.Color(255,255,255));
				btnAgregarEmpresa.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregarEmpresa.actionPerformed, event="+evt);
						//TODO add your code for btnAgregarEmpresa.actionPerformed
						btnAgregarEmpresa_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(223, 210, 136, 40);
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
			{
				contEmpresa = new JLabel();
				getContentPane().add(contEmpresa);
				contEmpresa.setText("Contacto Empresa");
				contEmpresa.setBounds(22, 170, 118, 16);
			}
			{
				txtContactoEmpresa = new JTextField();
				getContentPane().add(txtContactoEmpresa);
				txtContactoEmpresa.setBounds(145, 167, 214, 23);
			}
			pack();
			this.setSize(422, 311);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegistrarEmpresa.this.dispose();		
	}
	
	private void btnAgregarEmpresa_actionPerformed(ActionEvent evt) {
		//String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa
		String numEmpresa,nomEmpresa,direcEmpresa,telEmpresa,contactoEmpresa,mjs;

		try {
			numEmpresa=txtNumEmpresa.getText();
			nomEmpresa=txtNomEmpresa.getText();
			direcEmpresa=txtDirecEmpresa.getText();
			telEmpresa=txtTelEmpresa.getText();
			contactoEmpresa=txtContactoEmpresa.getText();
			mjs=gestor.AgregarEmpresa(numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
