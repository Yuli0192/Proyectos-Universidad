package capaPresentacion;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

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
public class PantallaRegistrarCuenta extends javax.swing.JFrame {
	private JComboBox cbxNumComunidad;
	private JLabel numComunidad;
	private Gestor gestor;
	private JLabel numCuenta;
	private JTextField txtNumCuenta;
	private JTextField txtMonto;
	private JButton btnRegistrar;
	private JLabel monto;
	private JLabel fec;
	private JLabel fech;
	private JTextField txtFecha;
	private JButton btnRegresar;
	
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaRegistrarCuenta inst = new PantallaRegistrarCuenta();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaRegistrarCuenta() {
		super();
		initGUI();
		gestor=new Gestor();
		cargarDatosComunidades();
	}
	private void cargarDatosComunidades() {
		txtFecha.setText(gestor.obtenerFechaHoy());
		String [] listaAbogados = gestor.obtenerTodasLasComunidades();
		for(int i=0; i<listaAbogados.length;i++){
			
			cbxNumComunidad.addItem(listaAbogados[i]);		
		}
	}
	
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Registrar Cuenta");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				ComboBoxModel cbxNumComunidadModel = new DefaultComboBoxModel(new String[] {  });
				cbxNumComunidad = new JComboBox();
				getContentPane().add(cbxNumComunidad);
				cbxNumComunidad.setModel(cbxNumComunidadModel);
				cbxNumComunidad.setBounds(166, 22, 253, 26);
			}
			{
				numComunidad = new JLabel();
				getContentPane().add(numComunidad);
				numComunidad.setText("Numero de Comunidad");
				numComunidad.setBounds(12, 22, 154, 26);
			}
			{
				txtNumCuenta = new JTextField();
				getContentPane().add(txtNumCuenta);
				txtNumCuenta.setBounds(166, 68, 253, 23);
			}
			{
				numCuenta = new JLabel();
				getContentPane().add(numCuenta);
				numCuenta.setText("NumeroCuenta");
				numCuenta.setBounds(12, 68, 154, 23);
			}
			{
				txtFecha = new JTextField();
				getContentPane().add(txtFecha);
				txtFecha.setBounds(166, 109, 140, 23);
			}
			{
				fech = new JLabel();
				getContentPane().add(fech);
				fech.setText("Ej: 22/07/2011");
				fech.setBounds(312, 112, 107, 20);
			}
			{
				fec = new JLabel();
				getContentPane().add(fec);
				fec.setText("Fecha");
				fec.setBounds(12, 112, 98, 20);
			}
			{
				monto = new JLabel();
				getContentPane().add(monto);
				monto.setText("Monto");
				monto.setBounds(12, 149, 154, 22);
			}
			{
				txtMonto = new JTextField();
				getContentPane().add(txtMonto);
				txtMonto.setBounds(166, 149, 140, 22);
			}
			{
				btnRegistrar = new JButton();
				getContentPane().add(btnRegistrar);
				btnRegistrar.setText("Registrar");
				btnRegistrar.setBounds(12, 197, 154, 38);
				btnRegistrar.setBackground(new java.awt.Color(255,255,255));
				btnRegistrar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/dis.gif")));
				btnRegistrar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegistrar.actionPerformed, event="+evt);
						//TODO add your code for btnRegistrar.actionPerformed
						btnRegistrar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(273, 196, 155, 39);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}

				});
			}
			pack();
			this.setSize(455, 298);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	

	private void btnRegistrar_actionPerformed(ActionEvent evt) {
		String numCuenta,numComunidad,fecha,mjs;
		int monto;

		try {
			numCuenta=txtNumCuenta.getText();
			numComunidad=(String) cbxNumComunidad.getSelectedItem();
			fecha=txtFecha.getText();
			monto=Integer.parseInt(txtMonto.getText());
			mjs=gestor.AgregarCuenta(numCuenta, numComunidad, fecha, monto);
			JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
			txtNumCuenta.setText("");
			txtFecha.setText("");
			txtMonto.setText("");
		} catch (Exception e) {
			
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP=new PantallaPrincipal();
		PP.setVisible(true);
		PantallaRegistrarCuenta.this.dispose();
		
	}

}
